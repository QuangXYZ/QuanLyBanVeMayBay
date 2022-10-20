namespace QuanLyBanVeMayBay
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fHome f = new fHome();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}