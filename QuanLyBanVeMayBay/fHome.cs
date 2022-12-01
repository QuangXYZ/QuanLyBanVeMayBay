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
<<<<<<< Updated upstream
using System.Globalization;

=======
>>>>>>> Stashed changes
namespace QuanLyBanVeMayBay
{
    public partial class fHome : Form
    {
<<<<<<< Updated upstream
    
       
        public fHome()
        {
            InitializeComponent();
            dataGridView3.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.DataSource = GetAllSanBay().Tables[0];
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically;
            
;


            dataGridView4.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView4.DataSource = GetAllVe().Tables[0];
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.MultiSelect = false;
           

            dataGridView5.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView5.DataSource = GetAllChuyenBayVe().Tables[0];
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.MultiSelect = false;
           

            dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.DataSource = GetAllChuyenBay().Tables[0];
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            

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
            String[] search = { "MACHUYENBAY", "MAMAYBAY", "SANBAYDI", "SANBAYDEN", "NGAYBAY" };
            for (int i = 0; i < search.Length; i++)
            {
                comboBox6.Items.Add(search[i]);
            }
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
=======
        SqlConnection sqlConn;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        void ConnectSql()
        {
            sqlConn = new SqlConnection(ConnectionString.connectionString);
        }
        public fHome()
        {
            InitializeComponent();
            dataGridView3.DataSource = GetAllSanBay();
        }
        DataSet GetAllSanBay()
        {
            ConnectSql();
            sqlConn.Open();
            string sql = "Select * from SANBAY";
>>>>>>> Stashed changes
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            return ds;
<<<<<<< Updated upstream

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

        DataSet GetAllChuyenBayVe()
        {
            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select MACHUYENBAY from CHUYENBAY";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            return ds;
        }
=======
            
        }
        void LoadDataView()
        {
           
        }
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView4.Rows[e.RowIndex];
            textBox2.Text = Convert.ToString(row.Cells["MAVE"].Value);
            textBox3.Text = Convert.ToString(row.Cells["TENKHACHHANG"].Value);
            textBox4.Text = Convert.ToString(row.Cells["CMND"].Value);
            textBox5.Text = Convert.ToString(row.Cells["GIA"].Value);
            comboBox5.SelectedIndex = comboBox5.FindStringExact(Convert.ToString(row.Cells["HANGVE"].Value));
            comboBox1.SelectedIndex = comboBox1.FindStringExact(Convert.ToString(row.Cells["QUOCTICH"].Value));
            
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
            textBox22.Text = Convert.ToString(row.Cells["THUONGGIA"].Value);
            textBox21.Text = Convert.ToString(row.Cells["PHOTHONG"].Value);
            textMSCB.Text = Convert.ToString(row.Cells["MACHUYENBAY"].Value);
            textBox8.Text = Convert.ToString(row.Cells["SOLUONGBANHANG1"].Value);
            textBox9.Text = Convert.ToString(row.Cells["SOLUONGBANHANG1"].Value);
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
            DialogResult r = MessageBox.Show("Bạn có muốn thoát chương trình 🤔", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == null || comboBox6.SelectedItem.ToString()== null) return;
            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from CHUYENBAY where "+comboBox6.SelectedItem.ToString()+" ='"+textBox6.Text+"'";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            int i = dataGridView1.SelectedRows[0].Index;
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "delete from CHUYENBAY where MACHUYENBAY ='" + Convert.ToString(dataGridView1[0,i].Value) + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            int result = cmd.ExecuteNonQuery();        
            sqlConn.Close();
            if (i > 0)
            {
                MessageBox.Show("Xóa thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = GetAllChuyenBay().Tables[0];
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConn;
                sqlConn = new SqlConnection(ConnectionString.connectionString);
                sqlConn.Open();
                string sql = "update CHUYENBAY set MAMAYBAY=@MAMAYBAY,SANBAYDI=@SANBAYDI,SANBAYDEN=@SANBAYDEN,SOLUONGGHE=@SOLUONGGHE,THUONGGIA=@THUONGGIA,PHOTHONG=@PHOTHONG,NGAYBAY=@NGAYBAY where MACHUYENBAY=@MACHUYENBAY ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@MACHUYENBAY", textMSCB.Text);
                cmd.Parameters.AddWithValue("@MAMAYBAY", comboBox3.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@SANBAYDI", comboBox4.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@SANBAYDEN", comboBox5.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@SOLUONGGHE", int.Parse(textBox21.Text) + int.Parse(textBox22.Text));
                cmd.Parameters.AddWithValue("@THUONGGIA", int.Parse(textBox22.Text));
                cmd.Parameters.AddWithValue("@PHOTHONG", int.Parse(textBox21.Text));
                cmd.Parameters.AddWithValue("@NGAYBAY", DateTime.ParseExact(textBox7.Text.Remove(textBox7.Text.Length - 3), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture));
                int result = cmd.ExecuteNonQuery();
                if (result >= 0)
                {
                    MessageBox.Show("Thêm thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = GetAllChuyenBay().Tables[0];
                }
                else { MessageBox.Show("Thêm không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                sqlConn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Thêm không thành công\n" + exp, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection sqlConn;
                sqlConn = new SqlConnection(ConnectionString.connectionString);
                sqlConn.Open();
                string sql = "insert into VE(MAVE,MACHUYENBAY,MAKHACHHANG,TENKHACHHANG,CMND,QUOCTICH,GIA,HANGVE) values " +
                    "(@MAVE,@MACHUYENBAY,@MAKHACHHANG,@TENKHACHHANG,@CMND,@QUOCTICH,@GIA,@HANGVE)";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.Add("@MAVE", SqlDbType.Char).Value = textBox2.Text;
                cmd.Parameters.Add("@MACHUYENBAY", SqlDbType.Char).Value = Convert.ToString(dataGridView5[0, dataGridView5.SelectedRows[0].Index].Value);
                cmd.Parameters.Add("@MAKHACHHANG", SqlDbType.Char).Value = "0";
                cmd.Parameters.Add("@TENKHACHHANG", SqlDbType.Char).Value = textBox3.Text;
                cmd.Parameters.Add("@CMND", SqlDbType.Char).Value = textBox4.Text;
                cmd.Parameters.Add("@QUOCTICH", SqlDbType.Char).Value = comboBox7.SelectedItem.ToString();
                cmd.Parameters.Add("@GIA", SqlDbType.Char).Value = textBox5.Text; ;
                cmd.Parameters.Add("@HANGVE", SqlDbType.Char).Value = comboBox1.SelectedItem.ToString();              
                int result = cmd.ExecuteNonQuery();
                if (result >= 0)
                {
                    MessageBox.Show("Thêm thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView4.DataSource = GetAllVe().Tables[0];
                }
                else { MessageBox.Show("Thêm không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                sqlConn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Thêm không thành công\n" + exp, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 0) return;
            int i = dataGridView4.SelectedRows[0].Index;
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "delete from VE where MAVE ='" + Convert.ToString(dataGridView4[0, i].Value) + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            int result = cmd.ExecuteNonQuery();
            sqlConn.Close();
            if (i > 0)
            {
                MessageBox.Show("Xóa thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView4.DataSource = GetAllVe().Tables[0];
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView5.Rows[e.RowIndex];
            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from VE where MACHUYENBAY = '" + Convert.ToString(row.Cells["MACHUYENBAY"].Value) + "'";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            dataGridView4.DataSource = ds.Tables[0];
        }

        private void button9_Click(object sender, EventArgs e)
        {           
                if (textBox1.Text == null) return;
                SqlConnection sqlConn;
                SqlDataAdapter da;
                DataSet ds = new DataSet();
                sqlConn = new SqlConnection(ConnectionString.connectionString);
                sqlConn.Open();
                string sql = "Select * from VE where " + comboBox6.SelectedItem.ToString() + " ='" + textBox6.Text + "'";
                da = new SqlDataAdapter(sql, sqlConn);
                da.Fill(ds);
                sqlConn.Close();
                dataGridView1.DataSource = ds.Tables[0];
            }
=======
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetAllSanBay();
>>>>>>> Stashed changes
        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
