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

namespace QuanLyBanVeMayBay
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select count(*) from CHUYENBAY ";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            Int32 result = (Int32)cmd.ExecuteScalar();
            sqlConn.Close();
            label2.Text = Convert.ToString(result);


            sqlConn.Open();
            sql = "Select count(*) from VE ";
            cmd = new SqlCommand(sql, sqlConn);
            result = (Int32)cmd.ExecuteScalar();
            sqlConn.Close();
            label3.Text = Convert.ToString(result);

            sqlConn.Open();
            sql = "Select count(*) from MAYBAY ";
            cmd = new SqlCommand(sql, sqlConn);
            result = (Int32)cmd.ExecuteScalar();
            sqlConn.Close();
            label5.Text = Convert.ToString(result);

            sqlConn.Open();
            sql = "Select count(*) from SANBAY ";
            cmd = new SqlCommand(sql, sqlConn);
            result = (Int32)cmd.ExecuteScalar();
            sqlConn.Close();
            label7.Text = Convert.ToString(result);

            sqlConn.Open();
            sql = "Select count(*) from NHANVIEN ";
            cmd = new SqlCommand(sql, sqlConn);
            result = (Int32)cmd.ExecuteScalar();
            sqlConn.Close();
            label9.Text = Convert.ToString(result);

            sqlConn.Open();
            sql = "Select count(*) from USERS ";
            cmd = new SqlCommand(sql, sqlConn);
            result = (Int32)cmd.ExecuteScalar();
            sqlConn.Close();
            label11.Text = Convert.ToString(result);

            DoanhThu();
            DoanhThuThuongGia();
            DoanhThuPhoThong();
        }
        private void DoanhThu()
        {
            int sum=0;
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from VE ";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
          
               sum += int.Parse(dr["GIA"].ToString());

            }
            sqlConn.Close();
            label15.Text = sum + " VND";
        }
        private void DoanhThuPhoThong()
        {
            int sum = 0;
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from VE where HANGVE = 'Pho thong'";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                sum += int.Parse(dr["GIA"].ToString());

            }
            sqlConn.Close();
            label19.Text = sum + " VND";
        }
        private void DoanhThuThuongGia()
        {
            int sum = 0;
            SqlConnection sqlConn;
            sqlConn = new SqlConnection(ConnectionString.connectionString);
            sqlConn.Open();
            string sql = "Select * from VE where HANGVE = 'Thuong gia' ";
            SqlCommand cmd = new SqlCommand(sql, sqlConn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                sum += int.Parse(dr["GIA"].ToString());

            }
            sqlConn.Close();
            label17.Text = sum + " VND";
        }
    }
}
