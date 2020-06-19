using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BankManager.DAL;
using BankManager.Models;
using BankManager.DTO.Enums;
using BankManager.DTO;

namespace BankManager
{
    public partial class frminformationCustomer : Form
    {
        private DataRow customerinfo;
        private void setdata(DataRow customerinfo)
        {
            string qry = string.Format(@"SELECT CustomerId, FirstName, LastName, IDNumber, Phone FROM [dbo].[Customer] WHERE CustomerId = {0}",Program.CustomerId.ToString());
            string qry1 = string.Format(@"SELECT AccountNumber,CreateTime,ExpireDate,Money FROM [dbo].[Account] WHERE CustomerId={0}",Program.CustomerId.ToString());
                var infocustomers = SQLProvider.Single(qry);
                var info = SQLProvider.Single(qry1);
                textBox1.Text = infocustomers["FirstName"] + string.Empty;
                textBox2.Text = infocustomers["LastName"] + string.Empty;
                textBox3.Text = infocustomers["IDNumber"] + string.Empty;
                textBox7.Text = infocustomers["Phone"] + string.Empty;
                textBox9.Text = info["AccountNumber"] + string.Empty;
                textBox5.Text = info["CreateTime"] + string.Empty;
                textBox8.Text = info["ExpireDate"] + string.Empty;
                txtmoney.Text = info["Money"] + string.Empty;
        }
        public frminformationCustomer()
        {
            InitializeComponent();
        }
        private void frminformationCustomer_Load(object sender, EventArgs e)
        {
            setdata(customerinfo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
