namespace fileDBforThumbNail
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
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
    }
}