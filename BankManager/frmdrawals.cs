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
    public partial class frmdrawals : Form
    {
        public frmdrawals()
        {
            InitializeComponent();
        }
        //Kiểm tra trạng thái hiện tại của tài khoản đã bị khóa hay không, Nếu tài khoản đã bị khóa thì xuất ra thông báo.
        //Nếu số tiền rút lớn hơn số tiền hiện tại thì xuất ra thông báo.
        //Nếu số tiền rút Lớn hơn 5tr và nhỏ hơn 50k thì xuất ra thông báo.
        // nếu số tiền rút + mức phí+ số dư phải còn lại trong tài khoản lớn hơn số tiền hiện tại thì thông báo lỗi.
        // số tiền rút tối đa 1 ngyaf 50tr.
        // phí rút tiền 1 lần giao dịch là 0.01%.
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAccn.Text != "")
            {
                try
                {
                    int accn = int.Parse(txtAccn.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Account Number is the number and not is blank");
                }
            }

            if (txtMoney.Text != "")
            {
                try
                {
                    decimal money = decimal.Parse(txtMoney.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Money is the number and not is blank");
                }
            }
            if (txtTranst.Text != "")
            {
                try
                {
                    int trans = int.Parse(txtTranst.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("TransacsionId is the number");
                }
            }
            SqlConnection cn = new SqlConnection("Data Source=LOWJI\\SQLEXPRESS;Database=Quanlytaikhoannganhang;User ID=sa;Password=123456");
            SqlCommand cmd = new SqlCommand("sp_Giaodich", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAGD", SqlDbType.Int).Value = txtTranst.Text;
            cmd.Parameters.Add("@TK_GIAODICH", SqlDbType.Int).Value = Program.AccountId;
            cmd.Parameters.Add("@LOAIGD", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@TK_NHAN ", SqlDbType.Int).Value = txtAccn.Text;
            cmd.Parameters.Add("@SOTIEN", SqlDbType.Int).Value = txtMoney.Text;
            cmd.Parameters.Add("@CHUYENRETURN", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cn.Open();
            cmd.ExecuteNonQuery();
            int ret = int.Parse(cmd.Parameters["@CHUYENRETURN"].Value.ToString());
            switch (ret)
            {
                case 0:
                    MessageBox.Show("withdraw money successfully");
                    txtAccn.ResetText();
                    break;
                case 1:
                    MessageBox.Show("You don't have enough available credit to complete the withdraw");
                    break;
                case 2:
                    MessageBox.Show("you can only draw 5 million at a time");
                    break;
                case 3:
                    MessageBox.Show("Limitation of transfering/day is 50.000.000 VND");
                    break;
                case 4:
                    MessageBox.Show("Account Loked");
                    break;
                case 5:
                    MessageBox.Show("Limitation of transfering greater than 20.000 and  Less than 5.000.000");
                    break;
                case 6:
                    MessageBox.Show("The remaining balance not enough to make a withdraw");
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
