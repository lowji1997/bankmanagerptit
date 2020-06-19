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
    public partial class frmaddatm : Form
    {
        public frmaddatm()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=LOWJI\SQLEXPRESS;Initial Catalog=Quanlytaikhoannganhang;Persist Security Info=True;User ID=sa;Password=123456";
       

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtaccnum.Text == "" || txtday.Text == "" || txttype.Text == "" || txtID.Text == "" || txtexp.Text == "" || txtstatus.Text == "" || txtmoney.Text == "")
            {
                MessageBox.Show("Bạn Chưa Nhập Đủ Thông Tin","LỖI",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("AtmAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@AccountNumber", txtaccnum.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@CreateTime", txtday.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Type", txttype.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@CustomerId", txtID.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ExpireDate", txtexp.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Status", txtstatus.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Money", txtmoney.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("THÀNH CÔNG");
                    Clear();
                }
            }
        }

        void Clear()
        {
            txtaccnum.Text = txtday.Text = txttype.Text = txtID.Text = txtexp.Text = txtstatus.Text = txtmoney.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
