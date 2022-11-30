using Numeria.IO;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace fileDBforThumbNail
{
    public partial class FrmMain : Form
    {
        DataTable dtOrg = new DataTable();
        int thumbsPerPage = 50; // 1페이지에 50개 픽쳐박스 생성
        int currentPage = 0;
        public FrmMain()
        {
            InitializeComponent();

            //DoubleBuffered = true;  //실패인듯.....
            ////출처 : http://chungjs9.blogspot.com/2011/06/c.html
            //SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            //SetStyle(ControlStyles.DoubleBuffer, true);
            //SetStyle(ControlStyles.UserPaint, true);

            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.UpdateStyles();

            toolStripStatusLabel1.Text = "Total Count  :";//$"{num}/{selectedAlignments.Count}";
            toolStripStatusLabel2.Text = $"{0}";//$"{num}/{selectedAlignments.Count}";
            toolStripStatusLabel3.Text = "Current page :";//$"{num}/{selectedAlignments.Count}";
            toolStripStatusLabel4.Text = $"{0}";// $"{mainDGV.RowCount}";//$"{num}/{selectedAlignments.Count}";
            
            dtOrg.Clear();//초기화
            dtOrg.Columns.Add("img1", typeof(string));   //Info.FileName    
            dtOrg.Columns.Add("img1_id", typeof(string)); //Info.ID
        }

        private void BtnFilePath0_Click(object sender, EventArgs e)
        {
            //fileDB경로 가져오기
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "fileDB files (*.fdb)|*.fdb|All files (*.*)|*.*",
                Title = "fileDB 파일"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
                TxtFileDBPath.Text = ofd.FileName;

        }

        private void move(object sender, EventArgs e)//resimlerin üzerine mause geldiğinde büyüten kod kısmı
        {
            PictureBox pcb = (PictureBox)sender;

            //string Nome = pcb.ImageLocation.Remove(0, LenLocal + 1);

            pcb.Width = 200;
            pcb.Height = 200;

        }
        private void leave(object sender, EventArgs e)
        {
            PictureBox pcb = (PictureBox)sender;

            pcb.Height = 100;
            pcb.Width = 120;
            pcb.Refresh();
        }

        private void clique(object sender, EventArgs e)//resmin orjinal halini gösterdiğimiz yer
        {
            PictureBox pcb = (PictureBox)sender;
            //string Nome = pcb.ImageLocation.Remove(0, LenLocal + 1);

            Form frm = new Form();
            frm.Width = pcb.Image.Width + 15;
            frm.Height = pcb.Image.Height + 30;
            frm.BackgroundImage = pcb.Image;
            frm.BackgroundImageLayout = ImageLayout.Stretch;
            frm.FormBorderStyle = FormBorderStyle.SizableToolWindow;

            //frm.Text = Nome;

            frm.ShowDialog();
        }

        private void BtnDBLoad_Click_1(object sender, EventArgs e)
        {
            var pathDB = TxtFileDBPath.Text;
            //while (flowLayoutPanel1.Controls.Count > 0) flowLayoutPanel1.Controls.RemoveAt(0);
            int imgCount = 0;
            using (FileDB db = new FileDB(pathDB, FileAccess.Read))
            {
                //return db.ListFiles();
                // 참고 : https://csharp.hotexamples.com/examples/Joy.Data/FileDB/ListFiles/php-filedb-listfiles-method-examples.html

                while (flowLayoutPanel1.Controls.Count > 0) flowLayoutPanel1.Controls.RemoveAt(0);  //초기화

                EntryInfo[] list = db.ListFiles();

                DataRow dtRow = null;
                dtOrg = new DataTable();
                dtOrg.Columns.Add("img1", typeof(string));   //Info.FileName    
                dtOrg.Columns.Add("img1_id", typeof(string)); //Info.ID

                for (int i = 0; i < list.Length; i++)
                {
                    EntryInfo info = list[i];
                    if (info.FileName.Contains(".jpg")
                        || info.FileName.Contains(".jpeg")
                        || info.FileName.Contains(".bmp")
                        || info.FileName.Contains(".png")
                        || info.FileName.Contains(".gif")
                        )
                    {

                        //Datatable  No와 info.ID와 info.FileName 추가
                        dtRow = dtOrg.NewRow();
                        dtRow["img1"] = info.FileName.ToString();
                        dtRow["img1_id"] = info.ID.ToString();
                        //var info = db.Search(Guid.Parse(TxtID.Text));
                        dtOrg.Rows.Add(dtRow);

                        ////toolStripStatusLabel3.Text = "num :";//$"{num}/{selectedAlignments.Count}";
                        //toolStripStatusLabel4.Text = $"{i}";// $"{mainDGV.RowCount}";//$"{num}/{selectedAlignments.Count}";
                        //statusStrip1.Refresh(); 
                    }

                }
                ////toolStripStatusLabel1.Text = "Total Rows :" ;//$"{num}/{selectedAlignments.Count}";
                toolStripStatusLabel2.Text = $"{dtOrg.Rows.Count}";//$"{num}/{selectedAlignments.Count}";
                //statusStrip1.Refresh();




                //page 세팅

                LblTpage.Text = $"{dtOrg.Rows.Count/ thumbsPerPage + 1}";
            }



        }

        private void BtnPageGo_Click(object sender, EventArgs e)
        {
            //참고 : https://stackoverflow.com/questions/4880236/how-can-i-implement-the-paging-effect-in-a-flowlayoutpanel-control
            //FlowPanel.Items.Clear();
            //for (int i = (currentPage - 1) * thumbsPerPage; i < (currentPage * thumbsPerPage) - 1; i++)
            //    FlowPanel.Controls.Add(Pedits[i]);
            flowLayoutPanel1.Controls.Clear();
            currentPage = Convert.ToInt32(TbCpage.Text); //현재 페이지
            if (currentPage <= 0) return;  //조건에 안맞으면 탈출
            toolStripStatusLabel4.Text = $"{currentPage}";

            var pathDB = TxtFileDBPath.Text;
            using (FileDB db = new FileDB(pathDB, FileAccess.Read))
            {
                for (int i = (currentPage - 1) * thumbsPerPage; i < (currentPage * thumbsPerPage); i++)
                {
                    //FlowPanel.Controls.Add(Pedits[i]);
                    
                    if (dtOrg.Rows.Count <= i) return; //범위를 벗어나면 탈출

                    PictureBox pcb = new PictureBox();
                    pcb.SizeMode = PictureBoxSizeMode.StretchImage;
                    //pcb.ImageLocation = image;
                    
                    using (MemoryStream output = new MemoryStream())
                    {
                        // db.Read(info.ID, output);
                        db.Read(Guid.Parse(dtOrg.Rows[i][1].ToString()), output); // 참고 : https://onlyican.tistory.com/157
                        Image image = Image.FromStream(output);

                        pcb.Image = image;

                    }
                    pcb.Height = 100;
                    pcb.Width = 120;

                    pcb.MouseMove += new MouseEventHandler(move);
                    pcb.MouseLeave += new EventHandler(leave);
                    pcb.Click += new EventHandler(clique);
                    flowLayoutPanel1.Controls.Add(pcb); //버벅임???

                    flowLayoutPanel1.Refresh();
                }

            }

        }
    }
}