using System.Data.SqlClient;
using System.Data;
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
           
                SqlConnection sqlConn;
                sqlConn = new SqlConnection(ConnectionString.connectionString);
                
                if (textBox2.Text.Length!=0&& textBox1.Text.Length!=0)
                {
                    sqlConn.Open();
                    string sql = "select COUNT(*) from USERS a where a.TENUSER='" + textBox2.Text + "' and a.MATKHAU='" + textBox1.Text + "'";
                    SqlCommand command = new SqlCommand(sql, sqlConn);


                    int i = (int)command.ExecuteScalar();
                    if (i!=0)
                    {
                        fHome f = new fHome();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                     }
                    else
                {
                    MessageBox.Show("Sai thông tin đăng nhập");

                }
                sqlConn.Close();
                 }
                 else
                {
                MessageBox.Show("Nhập thông tin không đầy đủ");
                }
               
        }
    }
}