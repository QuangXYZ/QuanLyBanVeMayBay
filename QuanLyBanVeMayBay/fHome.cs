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
namespace QuanLyBanVeMayBay
{
    public partial class fHome : Form
    {
    
       
        public fHome()
        {
            InitializeComponent();
            dataGridView3.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.DataSource = GetAllSanBay().Tables[0];

            dataGridView4.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView4.DataSource = GetAllVe().Tables[0];

            dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.DataSource = GetAllChuyenBay().Tables[0];


        }

        DataSet GetAllSanBay()
        {
            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn  = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from SANBAY";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            return ds;

        }
        DataSet GetAllVe()
        {
            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from VE";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            return ds;

        }
        DataSet GetAllChuyenBay()
        {
            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from CHUYENBAY";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            return ds;

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fHome_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát chương trình","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }
    }
}
