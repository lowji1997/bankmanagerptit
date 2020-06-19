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
    public partial class Formloginchange : Form
    {
        public Formloginchange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        SqlConnection cn = new SqlConnection(@"Data Source=LOWJI\SQLEXPRESS;Initial Catalog=Quanlytaikhoannganhang;Persist Security Info=True;User ID=sa;Password=123456");
        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select count (*) from [dbo].[User] where Username = N'" + txttendangnhap.Text + "'and Password = N'" + txtmatkhaucu.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (txtmatkhaumoi.Text == txtnhaplaimk.Text)
                {
                    if (txtmatkhaumoi.Text.Length > 5)//MK dài hơn 6 kí tự
                    {
                        SqlDataAdapter da1 = new SqlDataAdapter("update [dbo].[User] set Password = N'" + txtmatkhaumoi.Text + "'where Username = N'" + txttendangnhap.Text + "'and Password = N'" + txtmatkhaucu.Text + "'", cn);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        MessageBox.Show("Đổi mật khẩu thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        errorProvider1.SetError(txtmatkhaumoi, "Độ dài mật khẩu phải trên 6 kí tự");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtmatkhaumoi, "Bạn chưa nhập mật khẩu");
                    errorProvider1.SetError(txtnhaplaimk, "Mật khẩu nhập lại chưa đúng");
                }
            }
            else
            {
                errorProvider1.SetError(txttendangnhap, "Tên tài khoản không đúng");
                errorProvider1.SetError(txtmatkhaucu, "Mật khẩu cũ không đúng");
            }
        }
    }
    }

