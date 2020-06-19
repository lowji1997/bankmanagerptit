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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn Thoát?", "EXIT", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmListUser().ShowDialog();
        }

        private void btnindanhsach_Click(object sender, EventArgs e)
        {
            new frmShowReport().ShowDialog();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
