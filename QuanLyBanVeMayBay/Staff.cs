using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace QuanLyBanVeMayBay
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        public Staff(String username) : this()
        {
            textBox1.Text = username;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(558, 523);
            panel2.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void updatePassword()
        {
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "update USERS set MATKHAU = @MATKHAU where TENUSER = @TENUSER";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            cmd.Parameters.AddWithValue("@TENUSER", textBox1.Text);
            cmd.Parameters.AddWithValue("@MATKHAU", textBox4.Text);
            int result = cmd.ExecuteNonQuery();
            if (result >= 0)
            {
                MessageBox.Show("Đổi thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            sqlConn.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);

            if (textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0)
            {
                sqlConn.Open();
                string sql = "select * from USERS where TENUSER='" + textBox1.Text + "'";
                
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    string pass= dr["MATKHAU"].ToString();
                    
                    if (pass.Trim().Equals(textBox2.Text.Trim()))
                    {
                       if (textBox3.Text.Equals(textBox4.Text))
                        {
                            updatePassword();                            
                        }
                       else
                        {
                            MessageBox.Show("Mật khẩu không trùng khớp", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không đúng", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                sqlConn.Close();


            }
            }
    }
}
