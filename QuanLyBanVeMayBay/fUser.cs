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

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
