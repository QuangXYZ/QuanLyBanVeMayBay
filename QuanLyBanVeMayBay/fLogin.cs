using System.Data.SqlClient;
using System.Data;
namespace QuanLyBanVeMayBay
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            RememberMe();
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
                        fHome f = new fHome(textBox2.Text);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                
                        if (checkBox1.Checked)
                        {
                            string[] str = { "true", textBox1.Text, textBox2.Text };
                            File.WriteAllLines("D:\\QLBVMB9\\QuanLyBanVeMayBay\\Remember.txt", str);
                        }
                }
                    else
                {
                    MessageBox.Show("Sai thông tin đăng nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               

                }
                sqlConn.Close();
                 }
                 else
                {
                     MessageBox.Show("Nhập thông tin không đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                }
               
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                File.WriteAllText("D:\\QLBVMB9\\QuanLyBanVeMayBay\\Remember.txt", "false");
            }
        }
        private void RememberMe()
        {
            string[] str = File.ReadAllLines("D:\\QLBVMB9\\QuanLyBanVeMayBay\\Remember.txt");
            if (str[0].Equals("true"))
            {
                checkBox1.Checked = true;
                textBox1.Text = str[1];
                textBox2.Text = str[2];
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
          
        }

        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender,e);
            }
        }
    }
}