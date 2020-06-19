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
using System.Data;
using System.Data.SqlClient;
using BankManager.DTO;

namespace BankManager
{
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection("Data Source=LOWJI\\SQLEXPRESS;Database=Quanlytaikhoannganhang;User Id=sa;Password=123456");
        private void LoadTransaction()
        {
            cn.Open();
            string sql = "select *from [dbo].[Transaction]";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader readdata = cmd.ExecuteReader();
            lstTransaction = new List<viewTrantionDTO>();
            while (readdata.Read())
            {
                lstTransaction.Add(new TransactionDTO
                {
                    Account = Convert.ToInt32(readdata["AccountId"]),
                    Amount = Convert.ToDecimal(readdata["Amount"]),
                    Fee = Convert.ToDecimal(readdata["Fee"]),
                    Total = Convert.ToDecimal(readdata["Total"]),
                    TransactionId = Convert.ToInt32(readdata["TransactionId"]),
                    Type = Convert.ToInt32(readdata["Type"]),
                    Time = Convert.ToDateTime(readdata["Time"]),
                    ReceiptId = Convert.ToInt32(readdata["ReceiptId"])
                });
            }

            cn.Close();
            dataGridView1.DataSource = lstTransaction;
        }
        private void frmTransaction_Load(object sender, EventArgs e)
        {
            LoadTransaction();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datemin = dateTimePicker1.Value.Date;
            DateTime datemax = dateTimePicker2.Value.Date;
            dataGridView1.DataSource = lstTransaction.Where(t => t.Time.Date >= datemin && t.Time.Date <= datemax).ToArray();
        }
        private List<viewTrantionDTO> lstTransaction;

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1) return;
            viewTrantionDTO temp = lstTransaction.Find(t => t.TransactionId == int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            frmPrintPay print = new frmPrintPay(temp);
            print.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
