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

namespace BankManager
{
    public partial class frmaddacc : Form
    {
        public frmaddacc()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=LOWJI\SQLEXPRESS;Initial Catalog=Quanlytaikhoannganhang;Persist Security Info=True;User ID=sa;Password=123456";
     

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtpass.Text == "" || txtfirs.Text == "" || txtlast.Text == "" || txttype.Text == "" || txtID.Text == "")
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtpass.Text != txtconfirm.Text)
                MessageBox.Show("Xác Nhận Mật Khẩu Chưa Đúng", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("AccAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Username", txtuser.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtpass.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtfirs.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtlast.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Type", txttype.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@CustomerId", txtID.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("THÀNH CÔNG");
                    Clear();
                }
            }
        }
        void Clear()
        {
            txtuser.Text = txtpass.Text = txtfirs.Text = txtlast.Text = txttype.Text = txtID.Text = txtconfirm.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
