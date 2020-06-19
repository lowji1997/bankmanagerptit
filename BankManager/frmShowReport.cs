using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManager
{
    public partial class frmShowReport : Form
    {
        //Ado.net showreport là tool hô xotrowj dùng show danh sách lên
        public frmShowReport()
        {
            InitializeComponent();
        }

        private void frmShowReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanlytaikhoannganhangDataSet.Customer' table. You can move, or remove it, as needed.
            this.CustomerTableAdapter.Fill(this.QuanlytaikhoannganhangDataSet.Customer);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
