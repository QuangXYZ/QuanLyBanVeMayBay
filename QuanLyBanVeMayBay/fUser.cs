using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyBanVeMayBay
{
    public partial class fUser : Form
    {
        public fUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
         
        {
            if (textBox1.Text == null || textBox2.Text == null) {
                MessageBox.Show("Nhập không đủ thông tin\n", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                try
            {
                SqlConnection sqlConn;
                sqlConn = new SqlConnection(ConnectionString.connectionString);
                sqlConn.Open();
                string sql = "insert into USERS(TENUSER,MATKHAU,ISADMIN) values " +
                    "(@TENUSER,@MATKHAU,@ISADMIN)";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.Add("@TENUSER", SqlDbType.Char).Value = textBox1.Text;
                cmd.Parameters.Add("@MATKHAU", SqlDbType.Char).Value = textBox2.Text;
                cmd.Parameters.Add("@ISADMIN", SqlDbType.Int).Value = checkBox1.Checked ? 1:0;
              
                int result = cmd.ExecuteNonQuery();
                if (result >= 0)
                {
                    MessageBox.Show("Thêm thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = getAllUser().Tables[0];
                }
                else { MessageBox.Show("Thêm không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                sqlConn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Thêm không thành công\n" + exp, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = Convert.ToString(row.Cells["TENUSER"].Value);
            textBox2.Text = Convert.ToString(row.Cells["MATKHAU"].Value);
            if (int.Parse(Convert.ToString(row.Cells["ISADMIN"].Value)) == 1)
            {
                checkBox1.Checked = true;
            }else
            {
                checkBox1.Checked = false;
            }
            



        }

        private void fUser_Load(object sender, EventArgs e)
        {
           
            dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.DataSource = getAllUser().Tables[0];
        }
        private DataSet getAllUser()
        {

            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from USERS";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            return ds;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            int i = dataGridView1.SelectedRows[0].Index;
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "delete from USERS where TENUSER ='" + Convert.ToString(dataGridView1[0, i].Value) + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            int result = cmd.ExecuteNonQuery();
            sqlConn.Close();
            if (i > 0)
            {
                MessageBox.Show("Xóa thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = getAllUser().Tables[0];
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConn;
                sqlConn = new SqlConnection(ConnectionString.connectionString);
                sqlConn.Open();
                string sql = "update USERS set MATKHAU=@MATKHAU,ISADMIN=@ISADMIN where TENUSER=@TENUSER ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@TENUSER", textBox1.Text);
                cmd.Parameters.AddWithValue("@MATKHAU", textBox2.Text);
                cmd.Parameters.AddWithValue("@ISADMIN", checkBox1.Checked ? 1 : 0);
               
                int result = cmd.ExecuteNonQuery();
                if (result >= 0)
                {
                    MessageBox.Show("Sửa thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = getAllUser().Tables[0];
                }
                else { MessageBox.Show("Sửa không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                sqlConn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Sửa không thành công\n" + exp, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == null ) return;
            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from USERS where TENUSER = '" + textBox3.Text + "'";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            checkBox1.Checked = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
