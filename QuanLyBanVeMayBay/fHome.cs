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
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView3.Rows[0].Selected = true;
;


            dataGridView4.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView4.DataSource = GetAllVe().Tables[0];
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.EditMode = DataGridViewEditMode.EditProgrammatically;

            dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.DataSource = GetAllChuyenBay().Tables[0];
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.Rows[0].Selected = true;

            initAll();
        }

        void initAll()
        {
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from MAYBAY";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr["MAMAYBAY"].ToString());
            }
            sqlConn.Close();
            sqlConn.Open();
            sql = "Select * from SANBAY";
            SqlCommand cmd1 = new SqlCommand(sql, sqlConn);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox4.Items.Add(dr1["MASANBAY"].ToString());
            }
            sqlConn.Close();
            sqlConn.Open();
            sql = "Select * from SANBAY";
            SqlCommand cmd2 = new SqlCommand(sql, sqlConn);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox5.Items.Add(dr2["MASANBAY"].ToString());
            }
            sqlConn.Close();

        }
        DataSet GetAllSanBay()
        {
            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn  = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from MAYBAY";
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

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            textMSCB.Text = Convert.ToString(row.Cells["MACHUYENBAY"].Value);
            textBox7.Text = Convert.ToString(row.Cells["NGAYBAY"].Value);
            textBox21.Text = Convert.ToString(row.Cells["SOLUONGGHEHANG1"].Value);
            textBox22.Text = Convert.ToString(row.Cells["SOLUONGGHEHANG2"].Value);
            textMSCB.Text = Convert.ToString(row.Cells["MACHUYENBAY"].Value);
            comboBox3.SelectedIndex = comboBox3.FindStringExact(Convert.ToString(row.Cells["MAMAYBAY"].Value));
            comboBox4.SelectedIndex = comboBox4.FindStringExact(Convert.ToString(row.Cells["SANBAYDI"].Value));
            comboBox5.SelectedIndex = comboBox5.FindStringExact(Convert.ToString(row.Cells["SANBAYDEN"].Value));


        }




        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from MAYBAY where MAMAYBAY ='"+comboBox3.SelectedItem.ToString()+"'";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label25.Text = (dr["TENMAYBAY"].ToString());
                label27.Text = (dr["LOAI"].ToString());
                label29.Text = (dr["SOGHE"].ToString());

            }
            sqlConn.Close();
        }

        private void fHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát chương trình 🤔", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (r == DialogResult.Yes)
            {
               
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void fHome_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor=Color.Orange;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumSeaGreen;
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumSeaGreen;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from SANBAY where MASANBAY ='" + comboBox4.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label40.Text = (dr["TENSANBAY"].ToString());
                label41.Text = (dr["QUOCGIA"].ToString());
            }
            sqlConn.Close();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from SANBAY where MASANBAY ='" + comboBox5.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label42.Text = (dr["TENSANBAY"].ToString());
                label43.Text = (dr["QUOCGIA"].ToString());
            }
            sqlConn.Close();
        }
    }
}
