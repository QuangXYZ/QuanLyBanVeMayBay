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
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyBanVeMayBay
{
    public partial class fHome : Form
    {
    
       
        public fHome()
        {
            InitializeComponent();      
            
        }
        public fHome(string Username):this()
        {
            label3.Text = Username;

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
            string sql = "Select * from SANBAY";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            return ds;

        }
        DataSet GetAllNhanVien()
        {
            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from NhanVien";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            return ds;

        }

        DataSet GetAllMayBayNv()
        {
            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select MAMAYBAY from MAYBAY";
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
        DataSet GetAllMayBay()
        {
            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from MAYBAY";
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
            dataGridView3.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.MultiSelect = false;

            dataGridView9.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView9.AllowUserToAddRows = false;
            dataGridView9.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView9.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView9.MultiSelect = false;



            dataGridView4.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView4.DataSource = GetAllVe().Tables[0];
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.MultiSelect = false;

            dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.DataSource = GetAllChuyenBay().Tables[0];
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            dataGridView7.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView7.DataSource = GetAllChuyenBayVe().Tables[0];
            dataGridView7.AllowUserToAddRows = false;
            dataGridView7.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView7.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView7.MultiSelect = false;

            dataGridView8.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView8.DataSource = GetAllSanBay().Tables[0];
            dataGridView8.AllowUserToAddRows = false;
            dataGridView8.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView8.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView8.MultiSelect = false;



            dataGridView6.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView6.DataSource = GetAllMayBay().Tables[0];
            dataGridView6.AllowUserToAddRows = false;
            dataGridView6.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView6.MultiSelect = false;

            dataGridView10.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView10.DataSource = GetAllMayBayNv().Tables[0];
            dataGridView10.AllowUserToAddRows = false;
            dataGridView10.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView10.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView10.MultiSelect = false;

            dataGridView5.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView5.DataSource = GetAllNhanVien().Tables[0];
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.MultiSelect = false;


            initAll();
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

        private void button1_Click(object sender, EventArgs e)
        {
            fUser f = new fUser();
            this.Hide();
            f.ShowDialog();
          
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
   
            textMSCB.Text = Convert.ToString(row.Cells["MACHUYENBAY"].Value);
            textBox18.Text = Convert.ToString(row.Cells["SOLUONGBANHANG1"].Value);
            textBox32.Text = Convert.ToString(row.Cells["SOLUONGBANHANG2"].Value);
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
                textBox21.Text = (dr["THUONGGIA"].ToString());
                textBox22.Text = (dr["PHOTHONG"].ToString());
                

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

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConn;
                sqlConn = new SqlConnection(ConnectionString.connectionString);
                sqlConn.Open();
                string sql = "insert into CHUYENBAY(MACHUYENBAY,MAMAYBAY,SANBAYDI,SANBAYDEN,SOLUONGBANHANG1,SOLUONGBANHANG2,NGAYBAY) values " +
                    "(@MACHUYENBAY,@MAMAYBAY,@SANBAYDI,@SANBAYDEN,@SOLUONGBANHANG1,@SOLUONGBANHANG2,@NGAYBAY)";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.Add("@MACHUYENBAY", SqlDbType.Char).Value = textMSCB.Text;
                cmd.Parameters.Add("@MAMAYBAY", SqlDbType.Char).Value = comboBox3.SelectedItem.ToString();
                cmd.Parameters.Add("@SANBAYDI", SqlDbType.Char).Value = comboBox4.SelectedItem.ToString();
                cmd.Parameters.Add("@SANBAYDEN", SqlDbType.Char).Value = comboBox5.SelectedItem.ToString();
                cmd.Parameters.Add("@SOLUONGBANHANG1", SqlDbType.Int).Value = int.Parse(textBox22.Text);
                cmd.Parameters.Add("@SOLUONGBANHANG2", SqlDbType.Int).Value = int.Parse(textBox21.Text);
                cmd.Parameters.Add("@NGAYBAY", SqlDbType.SmallDateTime).Value = DateTime.ParseExact(textBox7.Text.Remove(textBox7.Text.Length - 3), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
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

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == null || comboBox8.SelectedItem.ToString() == null) return;
            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from CHUYENBAY where " + comboBox8.SelectedItem.ToString() + " ='" + textBox6.Text + "'";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0) return;
            int i = dataGridView1.SelectedRows[0].Index;
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "delete from CHUYENBAY where MACHUYENBAY ='" + Convert.ToString(dataGridView1[0, i].Value) + "'";
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
                string sql = "update CHUYENBAY set MAMAYBAY=@MAMAYBAY,SANBAYDI=@SANBAYDI,SANBAYDEN=@SANBAYDEN,NGAYBAY=@NGAYBAY where MACHUYENBAY=@MACHUYENBAY ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@MACHUYENBAY", textMSCB.Text);
                cmd.Parameters.AddWithValue("@MAMAYBAY", comboBox3.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@SANBAYDI", comboBox4.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@SANBAYDEN", comboBox5.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@NGAYBAY", DateTime.ParseExact(textBox7.Text.Remove(textBox7.Text.Length - 3), "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture));
                int result = cmd.ExecuteNonQuery();
                if (result >= 0)
                {
                    MessageBox.Show("Sửa thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = GetAllChuyenBay().Tables[0];
                }
                else { MessageBox.Show("Sửa không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                sqlConn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Sửa không thành công\n" + exp, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView7.Rows[e.RowIndex];
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

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView4.Rows[e.RowIndex];
            textBox2.Text = Convert.ToString(row.Cells["MAVE"].Value);
            textBox3.Text = Convert.ToString(row.Cells["TENKHACHHANG"].Value);
            textBox4.Text = Convert.ToString(row.Cells["CMND"].Value);
            textBox33.Text = Convert.ToString(row.Cells["GIA"].Value);
            comboBox1.SelectedIndex = comboBox1.FindStringExact(Convert.ToString(row.Cells["HANGVE"].Value));
            comboBox10.SelectedIndex = comboBox10.FindStringExact(Convert.ToString(row.Cells["QUOCTICH"].Value));
        }
        private int getSoLuongThuongGia(string MCB)
        {
            int soluong = 0;
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from CHUYENBAY where MACHUYENBAY ='" + MCB + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                soluong = int.Parse( (dr["SOLUONGBANHANG1"].ToString()));
            }
            sqlConn.Close();
            return soluong;
        }
        private int getSoLuongPhoThong(string MCB)
        {
            int soluong = 0;
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from CHUYENBAY where MACHUYENBAY ='" + MCB + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                soluong = int.Parse((dr["SOLUONGBANHANG2"].ToString()));
            }
            sqlConn.Close();
            return soluong;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int hang1 = 0;
            int hang2 = 0;
            if (comboBox1.SelectedItem.Equals("Thuong gia"))
            {
                hang1 = getSoLuongThuongGia(Convert.ToString(dataGridView7[0, dataGridView7.SelectedRows[0].Index].Value));
                if ( hang1 <= 0)
                {
                    MessageBox.Show("Chuyến bay đã hết vé hạng thương gia", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (comboBox1.SelectedItem.Equals("Pho thong"))
            {
                hang2 = getSoLuongPhoThong(Convert.ToString(dataGridView7[0, dataGridView7.SelectedRows[0].Index].Value));
                if (hang2 <= 0)
                {
                    MessageBox.Show("Chuyến bay đã hết vé hạng phổ thông", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            try
            {
                SqlConnection sqlConn;
                sqlConn = new SqlConnection(ConnectionString.connectionString);
                sqlConn.Open();
                string sql = "insert into VE(MAVE,MACHUYENBAY,MAKHACHHANG,TENKHACHHANG,CMND,QUOCTICH,GIA,HANGVE) values " +
                    "(@MAVE,@MACHUYENBAY,@MAKHACHHANG,@TENKHACHHANG,@CMND,@QUOCTICH,@GIA,@HANGVE)";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.Add("@MAVE", SqlDbType.Char).Value = textBox2.Text;
                cmd.Parameters.Add("@MACHUYENBAY", SqlDbType.Char).Value = Convert.ToString(dataGridView7[0, dataGridView7.SelectedRows[0].Index].Value);
                cmd.Parameters.Add("@MAKHACHHANG", SqlDbType.Char).Value = "0";
                cmd.Parameters.Add("@TENKHACHHANG", SqlDbType.Char).Value = textBox3.Text;
                cmd.Parameters.Add("@CMND", SqlDbType.Char).Value = textBox4.Text;
                cmd.Parameters.Add("@QUOCTICH", SqlDbType.Char).Value = comboBox10.SelectedItem.ToString();
                cmd.Parameters.Add("@GIA", SqlDbType.Char).Value = textBox33.Text;
                cmd.Parameters.Add("@HANGVE", SqlDbType.Char).Value = comboBox1.SelectedItem.ToString();
                SqlConnection sqlConn1;
                sqlConn1 = new SqlConnection(ConnectionString.connectionString);
                sqlConn1.Open();
                
                if (comboBox1.SelectedItem.Equals("Thuong gia"))
                {
                    string sql1 = "update CHUYENBAY set SOLUONGBANHANG1=@SOLUONGBANHANG1 where MACHUYENBAY=@MACHUYENBAY ";
                    SqlCommand cmd1 = new SqlCommand(sql1, sqlConn1);
                    cmd1.Parameters.AddWithValue("@SOLUONGBANHANG1",hang1-1);
                    cmd1.Parameters.AddWithValue("@MACHUYENBAY", Convert.ToString(dataGridView7[0, dataGridView7.SelectedRows[0].Index].Value));

                    int result1 = cmd1.ExecuteNonQuery();
                }
                if (comboBox1.SelectedItem.Equals("Pho thong"))
                {
                    string sql1 = "update CHUYENBAY set SOLUONGBANHANG2=@SOLUONGBANHANG2 where MACHUYENBAY=@MACHUYENBAY ";
                    SqlCommand cmd1 = new SqlCommand(sql1, sqlConn1);
                    cmd1.Parameters.AddWithValue("@SOLUONGBANHANG2", hang2 - 1);
                    cmd1.Parameters.AddWithValue("@MACHUYENBAY", Convert.ToString(dataGridView7[0, dataGridView7.SelectedRows[0].Index].Value));

                    int result1 = cmd1.ExecuteNonQuery();
                }
                sqlConn1.Close();
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

        private void button27_Click(object sender, EventArgs e)
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
            if (result > 0)
            {
                MessageBox.Show("Xóa thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView4.DataSource = GetAllVe().Tables[0];
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hang="";
            int i = dataGridView7.SelectedRows[0].Index;
            if (comboBox9.SelectedItem.Equals("Tất cả"))
            {
                
                SqlConnection sqlConn1;
                SqlDataAdapter da1;
                DataSet ds1 = new DataSet();
                sqlConn1 = new SqlConnection(ConnectionString.connectionString);
                sqlConn1.Open();
                string sql1 = "Select * from VE where MACHUYENBAY = '" + Convert.ToString(dataGridView7[0, i].Value) + "'";
                da1 = new SqlDataAdapter(sql1, sqlConn1);
                da1.Fill(ds1);
                sqlConn1.Close();
                dataGridView4.DataSource = ds1.Tables[0];
                return;
            }
            if (comboBox9.SelectedItem.Equals("Thương gia")) hang = "Thuong gia";
            if (comboBox9.SelectedItem.Equals("Phổ thông")) hang = "Pho thong";

            
            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from VE where MACHUYENBAY = '" + Convert.ToString(dataGridView7[0, i].Value) + "' and HANGVE = '"+hang+"'";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            dataGridView4.DataSource = ds.Tables[0];
        }
        private string GetNameSanBay(string MASB)
        {
            string name = "";
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from SANBAY where MASANBAY = '"+MASB+"'";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name = (dr["TENSANBAY"].ToString());
            }
            sqlConn.Close();
            return name;
        }
        private void button9_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from VE where MACHUYENBAY = '" + textBox1.Text + "'";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
           
            sqlConn.Close();
            dataGridView4.DataSource = ds.Tables[0];

            SqlConnection sqlConn1;
            sqlConn1 = new SqlConnection(ConnectionString.connectionString);
            sqlConn1.Open();
            string sql1 = "Select * from CHUYENBAY where MACHUYENBAY ='"+ textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql1, sqlConn1);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                label31.Text = GetNameSanBay (dr["SANBAYDI"].ToString());
                label33.Text = GetNameSanBay(dr["SANBAYDEN"].ToString());
              
            }
            sqlConn1.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView8.Rows[e.RowIndex];
            textBox23.Text = Convert.ToString(row.Cells["MASANBAY"].Value);
            textBox26.Text = Convert.ToString(row.Cells["TENSANBAY"].Value);
            textBox25.Text = Convert.ToString(row.Cells["QUOCGIA"].Value);

            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select MACHUYENBAY,MAMAYBAY,NGAYBAY from CHUYENBAY where SANBAYDI = '" + Convert.ToString(row.Cells["MASANBAY"].Value) + "'";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            dataGridView3.DataSource = ds.Tables[0];


       
            DataSet ds1 = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            sql = "Select MACHUYENBAY,MAMAYBAY,NGAYBAY from CHUYENBAY where SANBAYDEN = '" + Convert.ToString(row.Cells["MASANBAY"].Value) + "'";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds1);
            sqlConn.Close();
            dataGridView9.DataSource = ds1.Tables[0];

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConn;
                sqlConn = new SqlConnection(ConnectionString.connectionString);
                sqlConn.Open();
                string sql = "insert into SANBAY(MASANBAY,TENSANBAY,QUOCGIA) values "+
                    "(@MASANBAY,@TENSANBAY,@QUOCGIA)";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.Add("@MASANBAY", SqlDbType.Char).Value = textBox23.Text;
                cmd.Parameters.Add("@TENSANBAY", SqlDbType.Char).Value = textBox26.Text;
                cmd.Parameters.Add("@QUOCGIA", SqlDbType.Char).Value = textBox25.Text;         
                int result = cmd.ExecuteNonQuery();
                if (result >= 0)
                {
                    MessageBox.Show("Thêm thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView8.DataSource = GetAllSanBay().Tables[0];
                }
                else { MessageBox.Show("Thêm không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                sqlConn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Thêm không thành công\n" + exp, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (dataGridView8.SelectedRows.Count == 0) return;
            int i = dataGridView8.SelectedRows[0].Index;
            if (dataGridView3.RowCount!=0|| dataGridView9.RowCount != 0)
            {
                MessageBox.Show("Không thể xóa sân bay\nSân bay đang được sử dụng", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "delete from SANBAY where MASANBAY ='" + Convert.ToString(dataGridView8[0, i].Value) + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            int result = cmd.ExecuteNonQuery();
            sqlConn.Close();
            if (result > 0)
            {
                MessageBox.Show("Xóa thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView8.DataSource = GetAllSanBay().Tables[0];
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConn;
                sqlConn = new SqlConnection(ConnectionString.connectionString);
                sqlConn.Open();
                string sql = "update SANBAY set TENSANBAY=@TENSANBAY,QUOCGIA=@QUOCGIA where MASANBAY=@MASANBAY ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@TENSANBAY", textBox26.Text);
                cmd.Parameters.AddWithValue("@QUOCGIA", textBox25.Text);
                cmd.Parameters.AddWithValue("@MASANBAY", textBox23.Text);               
                int result = cmd.ExecuteNonQuery();
                if (result >= 0)
                {
                    MessageBox.Show("Sửa thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView8.DataSource = GetAllSanBay().Tables[0];
                }
                else { MessageBox.Show("Sửa không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                sqlConn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Sửa không thành công\n" + exp, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {

            if (textBox5.Text == null || comboBox2.SelectedItem.ToString() == null)
            {
                MessageBox.Show("Không đủ thông tin", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from SANBAY where " + comboBox2.SelectedItem.ToString() + " ='" + textBox5.Text + "'";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            dataGridView8.DataSource = ds.Tables[0];
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox23.Text = "";
            textBox26.Text = "";
            textBox25.Text = "";
            textBox5.Text = "";
            dataGridView8.DataSource = GetAllSanBay().Tables[0];
            comboBox2.SelectedIndex = 0;


        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (dataGridView6.SelectedRows.Count == 0) return;
            int i = dataGridView6.SelectedRows[0].Index;
            SqlConnection sqlConn1;
            sqlConn1 = new SqlConnection(ConnectionString.connectionString);
            sqlConn1.Open();
            string sql1 = "Select count(*) from CHUYENBAY where MAMAYBAY ='" + Convert.ToString(dataGridView6[0, i].Value) + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, sqlConn1);

            Int32 result1 = (Int32)cmd1.ExecuteScalar();
            sqlConn1.Close();

            if (result1>0)
            {
                MessageBox.Show("Không thể xóa máy bay\nMáy bay này đang được sử dụng", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "delete from MAYBAY where MAMAYBAY ='" + Convert.ToString(dataGridView6[0, i].Value) + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            int result = cmd.ExecuteNonQuery();
            sqlConn.Close();
            if (result > 0)
            {
                MessageBox.Show("Xóa thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView6.DataSource = GetAllMayBay().Tables[0];
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
             
        }

        private void button24_Click(object sender, EventArgs e)
        {           
            try
            {
                SqlConnection sqlConn;
                sqlConn = new SqlConnection(ConnectionString.connectionString);
                sqlConn.Open();
                string sql = "update MAYBAY set TENMAYBAY=@TENMAYBAY,SOGHE=@SOGHE,LOAI=@LOAI,THUONGGIA=@THUONGGIA,PHOTHONG=@PHOTHONG where MAMAYBAY=@MAMAYBAY ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@MAMAYBAY", textBox16.Text);
                cmd.Parameters.AddWithValue("@TENMAYBAY", textBox31.Text);
                cmd.Parameters.AddWithValue("@SOGHE", int.Parse(textBox20.Text) + int.Parse(textBox24.Text));
                cmd.Parameters.AddWithValue("@LOAI", textBox19.Text);
                cmd.Parameters.AddWithValue("@THUONGGIA", textBox20.Text);
                cmd.Parameters.AddWithValue("@PHOTHONG", textBox24.Text);
                int result = cmd.ExecuteNonQuery();
                if (result >= 0)
                {
                    MessageBox.Show("Sửa thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView6.DataSource = GetAllMayBay().Tables[0];
                }
                else { MessageBox.Show("Sửa không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                sqlConn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Sửa không thành công\n" + exp, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConn;
                sqlConn = new SqlConnection(ConnectionString.connectionString);
                sqlConn.Open();
                string sql = " insert into MAYBAY(MAMAYBAY,TENMAYBAY,LOAI,SOGHE,THUONGGIA,PHOTHONG) values  " +
                    "(@MAMAYBAY,@TENMAYBAY,@LOAI,@SOGHE,@THUONGGIA,@PHOTHONG)";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.Add("@MAMAYBAY", SqlDbType.Char).Value = textBox16.Text;
                cmd.Parameters.Add("@TENMAYBAY", SqlDbType.Char).Value = textBox31.Text;
                cmd.Parameters.Add("@LOAI", SqlDbType.Char).Value = textBox19.Text;
                cmd.Parameters.Add("@SOGHE", SqlDbType.Int).Value = int.Parse(textBox20.Text)+ int.Parse(textBox24.Text);
                cmd.Parameters.Add("@THUONGGIA", SqlDbType.Int).Value = int.Parse(textBox20.Text);
                cmd.Parameters.Add("@PHOTHONG", SqlDbType.Int).Value = int.Parse(textBox24.Text);
                int result = cmd.ExecuteNonQuery();
                if (result >= 0)
                {
                    MessageBox.Show("Thêm thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView6.DataSource = GetAllMayBay().Tables[0];
                }
                else { MessageBox.Show("Thêm không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                sqlConn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Thêm không thành công\n" + exp, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView6.Rows[e.RowIndex];
            textBox16.Text = Convert.ToString(row.Cells["MAMAYBAY"].Value);
            textBox31.Text = Convert.ToString(row.Cells["TENMAYBAY"].Value);
            textBox27.Text = Convert.ToString(row.Cells["SOGHE"].Value);
            textBox19.Text = Convert.ToString(row.Cells["LOAI"].Value);
            textBox20.Text = Convert.ToString(row.Cells["THUONGGIA"].Value);
            textBox24.Text = Convert.ToString(row.Cells["PHOTHONG"].Value);

          
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click_1(object sender, EventArgs e)
        {

        }

        private void heThongToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Refresh()
        {
            initAll();
            dataGridView4.DataSource = GetAllVe().Tables[0];
            dataGridView1.DataSource = GetAllChuyenBay().Tables[0];
            dataGridView7.DataSource = GetAllChuyenBayVe().Tables[0];
            dataGridView8.DataSource = GetAllSanBay().Tables[0];
            dataGridView6.DataSource = GetAllMayBay().Tables[0];
            dataGridView5.DataSource = GetAllNhanVien().Tables[0];
            dataGridView10.DataSource = GetAllMayBayNv().Tables[0];

        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }


        private void button16_Click(object sender, EventArgs e)
        {
            textMSCB.Text = "";
            textBox7.Text = "";

            textMSCB.Text = "";
            textBox18.Text = "";
            textBox32.Text = "";
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            textBox21.Text = "";
            textBox22.Text = "";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConn;
                sqlConn = new SqlConnection(ConnectionString.connectionString);
                sqlConn.Open();
                string sql = "update VE set TENKHACHHANG=@TENKHACHHANG,CMND=@CMND,QUOCTICH=@QUOCTICH,GIA=@GIA,HANGVE=@HANGVE where MAVE=@MAVE ";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);

                cmd.Parameters.AddWithValue("@TENKHACHHANG", textBox3.Text);
                cmd.Parameters.AddWithValue("@CMND", textBox4.Text);
                cmd.Parameters.AddWithValue("@QUOCTICH", comboBox10.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@GIA", textBox33.Text);
                cmd.Parameters.AddWithValue("@HANGVE", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@MAVE", textBox2.Text);

                int result = cmd.ExecuteNonQuery();
                if (result >= 0)
                {
                    MessageBox.Show("Sửa thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh();
                }
                else { MessageBox.Show("Sửa không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                sqlConn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Sửa không thành công\n" + exp, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView5.Rows[e.RowIndex];
            textBox8.Text = Convert.ToString(row.Cells["MANHANVIEN"].Value);
            textBox9.Text = Convert.ToString(row.Cells["TENNHANVIEN"].Value);
            textBox10.Text = Convert.ToString(row.Cells["SDT"].Value);
            textBox11.Text = Convert.ToString(row.Cells["MAMAYBAY"].Value);
            textBox12.Text = Convert.ToString(row.Cells["CMND"].Value);
            textBox14.Text = Convert.ToString(row.Cells["DIACHI"].Value);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConn;
                sqlConn = new SqlConnection(ConnectionString.connectionString);
                sqlConn.Open();
                string sql = "insert into NHANVIEN(MANHANVIEN,TENNHANVIEN,MAMAYBAY,CMND,SDT,DIACHI) values " +
                    "(@MANHANVIEN,@TENNHANVIEN,@MAMAYBAY,@CMND,@SDT,@DIACHI)";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.Add("@MANHANVIEN", SqlDbType.Char).Value = textBox8.Text;
                cmd.Parameters.Add("@TENNHANVIEN", SqlDbType.Char).Value = textBox9.Text;
                cmd.Parameters.Add("@MAMAYBAY", SqlDbType.Char).Value = Convert.ToString(dataGridView10[0, dataGridView10.SelectedRows[0].Index].Value);
                cmd.Parameters.Add("@CMND", SqlDbType.Char).Value = textBox12.Text;
                cmd.Parameters.Add("@SDT", SqlDbType.Char).Value = textBox10.Text;
                cmd.Parameters.Add("@DIACHI", SqlDbType.Char).Value = textBox14.Text;
       
                SqlConnection sqlConn1;
                sqlConn1 = new SqlConnection(ConnectionString.connectionString);
                sqlConn1.Open();


                int result = cmd.ExecuteNonQuery();
                if (result >= 0)
                {
                    MessageBox.Show("Thêm thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView5.DataSource = GetAllNhanVien().Tables[0];
                }
                else { MessageBox.Show("Thêm không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                sqlConn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Thêm không thành công\n" + exp, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView10_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView10.Rows[e.RowIndex];
            SqlConnection sqlConn;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from NHANVIEN where MAMAYBAY = '" + Convert.ToString(row.Cells["MAMAYBAY"].Value) + "'";
            da = new SqlDataAdapter(sql, sqlConn);
            da.Fill(ds);
            sqlConn.Close();
            dataGridView5.DataSource = ds.Tables[0];
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count == 0) return;
            int i = dataGridView5.SelectedRows[0].Index;
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "delete from NHANVIEN where MANHANVIEN ='" + Convert.ToString(dataGridView5[0, i].Value) + "'";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            int result = cmd.ExecuteNonQuery();
            sqlConn.Close();
            if (result > 0)
            {
                MessageBox.Show("Xóa thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView5.DataSource = GetAllNhanVien().Tables[0];
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {

               
                SqlConnection sqlConn;
                sqlConn = new SqlConnection(ConnectionString.connectionString);
                sqlConn.Open();
                string sql = "update NHANVIEN set TENNHANVIEN=@TENNHANVIEN,MAMAYBAY=@MAMAYBAY,CMND=@CMND,DIACHI=@DIACHI,SDT=@SDT where  MANHANVIEN=@MANHANVIEN";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                cmd.Parameters.AddWithValue("@TENNHANVIEN", textBox9.Text);
                cmd.Parameters.AddWithValue("@MAMAYBAY", textBox11.Text);
                cmd.Parameters.AddWithValue("@CMND", textBox10.Text);
                cmd.Parameters.AddWithValue("@DIACHI", textBox14.Text);
                cmd.Parameters.AddWithValue("@SDT", textBox10.Text);
                cmd.Parameters.AddWithValue("@MANHANVIEN", textBox8.Text);
                
                int result = cmd.ExecuteNonQuery();
                if (result >= 0)
                {
                    MessageBox.Show("Sửa thành công", "SUCCESSFUL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView5.DataSource = GetAllNhanVien().Tables[0];
                }
                else { MessageBox.Show("Sửa không thành công", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                sqlConn.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Sửa không thành công\n" + exp, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox14.Text = "";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox33.Text = "";
            comboBox10.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }
    }
}
