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
using System.Data;
using BankManager.DAL;
using Microsoft.Reporting.WinForms;
using BankManager.DTO;

namespace BankManager
{
    public partial class frmPrintPay : Form
    {
        private viewTrantionDTO _data;
        public frmPrintPay(viewTrantionDTO data)
        {
            InitializeComponent();
            _data = data;
        }
        private void frmPrintPay_Load(object sender, EventArgs e)
        {
            ReportParameter[] p = new ReportParameter[] {
            new ReportParameter("TransactionId",_data.TransactionId.ToString()),
            new ReportParameter("AccountId",_data.Account.ToString()),
            new ReportParameter("Time",_data.Time.ToString("d")),
            new ReportParameter("Amount",_data.Amount.ToString()),
            new ReportParameter("Fee", _data.Fee.ToString()),
            new ReportParameter("Total", _data.Total.ToString()),
            new ReportParameter("ReceiptId",_data.ReceiptId.ToString())
            };
            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
