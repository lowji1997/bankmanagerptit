using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManager.DAL;
using BankManager.DTO;
using System.Data.SqlClient;


namespace BankManager
{
    public partial class frmSend : Form
    {
        public frmSend()
        {
            InitializeComponent();
        }
       
        private void txtAccount_Click(object sender, EventArgs e)
        {
           
        }
        //Kiểm tra trạng thái hiện tại của tài khoản đã bị khóa hay không, Nếu tài khoản đã bị khóa thì xuất ra thông báo.

        // nếu số tiền chuyển lớn hơn số tiền hiện tại thì xuất ra thông báo
        //  Số tiền chuyển tối đa 100tr và ít nhất là 50k và số tiền trong tài khoản phải dư còn lại trong tài khoản ít nhất là 50k ,nếu số tiền chuyển + mức phí lớn hơn số dư thì lỗi
        //phí của 1 lần giao dịch 0.03%
        //nếu số tài khoản nhận tiền không đúng vầ số tài khoản không tồn tại  trong database thì xuất ra thông báo.

        private void btnOk_Click(object sender, EventArgs e)
        {
            TransactionDTO trt = new TransactionDTO();
           if(txtAccn.Text!="")
            {
                try
                {
                    int accn = int.Parse(txtAccn.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("Account Number is the number and not is blank");
                }
            }

            if(txtMoney.Text!="")
            {
                try
                {
                    decimal money = decimal.Parse(txtMoney.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("Money is the number and not is blank");
                }
            }
            if(txtTranst.Text!="")
            {
                try
                {
                    int trans = int.Parse(txtTranst.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("TransacsionId is the number and not is blank");
                }
            }
            SqlConnection cn = new SqlConnection("Data Source=LOWJI\\SQLEXPRESS;Initial Catalog=Quanlytaikhoannganhang;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_Giaodich", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAGD", SqlDbType.Int).Value = txtTranst.Text; 
            cmd.Parameters.Add("@TK_GIAODICH", SqlDbType.Int).Value = Program.AccountId;
            cmd.Parameters.Add("@LOAIGD", SqlDbType.Int).Value = 1;
            cmd.Parameters.Add("@TK_NHAN ", SqlDbType.Int).Value =txtAccn.Text;
            cmd.Parameters.Add("@SOTIEN", SqlDbType.Int).Value = txtMoney.Text;
            cmd.Parameters.Add("@CHUYENRETURN", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cn.Open();
            cmd.ExecuteNonQuery();
            int ret = int.Parse(cmd.Parameters["@CHUYENRETURN"].Value.ToString());


            switch (ret)
            {
                case 0:
                    MessageBox.Show("Transfer complete");
                    txtAccn.ResetText();
                    break;
                case 1:
                    MessageBox.Show("You don't have enough available credit to complete the transfe");
                    break;
                case 2:
                    MessageBox.Show("you can only transfer 100 million at a time");
                    break;
                case 3:
                    MessageBox.Show("Limitation of transfering/trading is 100.000.000 VND");
                    break;
                case 4:
                    MessageBox.Show("Account Loked");
                    break;
                case 5:
                    MessageBox.Show("Limitation of transfering greater than 20.000 and  Less than 100.000.000");
                    break;
                case 6:
                    MessageBox.Show("The remaining balance not enough to make a transfer");
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
