using Numeria.IO;
using System.Windows.Forms;

namespace fileDBforThumbNail
{
    public partial class FrmMain : Form
    {
        
        public FrmMain()
        {
            InitializeComponent();
            
            //DoubleBuffered = true;  //실패인듯.....

            //출처 : http://chungjs9.blogspot.com/2011/06/c.html
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);

            toolStripStatusLabel1.Text = "Total  :";//$"{num}/{selectedAlignments.Count}";
            toolStripStatusLabel2.Text = $"{0}";//$"{num}/{selectedAlignments.Count}";
            toolStripStatusLabel3.Text = "num";//$"{num}/{selectedAlignments.Count}";
            toolStripStatusLabel4.Text = $"{0}";// $"{mainDGV.RowCount}";//$"{num}/{selectedAlignments.Count}";

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

            using (FileDB db = new FileDB(pathDB, FileAccess.Read))
            {
                //return db.ListFiles();
                // 참고 : https://csharp.hotexamples.com/examples/Joy.Data/FileDB/ListFiles/php-filedb-listfiles-method-examples.html

                while (flowLayoutPanel1.Controls.Count > 0) flowLayoutPanel1.Controls.RemoveAt(0);  //초기화

                EntryInfo[] list = db.ListFiles();


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


                        PictureBox pcb = new PictureBox();
                        pcb.SizeMode = PictureBoxSizeMode.StretchImage;
                        //pcb.ImageLocation = image;

                        using (MemoryStream output = new MemoryStream())
                        {
                            db.Read(info.ID, output);
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

                        //시간이 오래걸리고 버벅이는 증상 해결못함.
                        Thread.Sleep(10);

                        //toolStripStatusLabel3.Text = "num :";//$"{num}/{selectedAlignments.Count}";
                        toolStripStatusLabel4.Text = $"{i}";// $"{mainDGV.RowCount}";//$"{num}/{selectedAlignments.Count}";
                        statusStrip1.Refresh(); 
                    }

                }
                //toolStripStatusLabel1.Text = "Total Rows :" ;//$"{num}/{selectedAlignments.Count}";
                toolStripStatusLabel2.Text = $"{list.Length}";//$"{num}/{selectedAlignments.Count}";
                statusStrip1.Refresh();



            }



        }
    }
}