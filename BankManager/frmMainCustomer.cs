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
    public partial class frmMainCustomer : Form
    {
        public frmMainCustomer()
        {
            InitializeComponent();
        }

        private void frmMainCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnthongtintk_Click(object sender, EventArgs e)
        {
            new frminformationCustomer().ShowDialog();

        }

        private void btnChuyentien_Click(object sender, EventArgs e)
        {
            new frmSend().ShowDialog();
        }

        private void btnruttien_Click(object sender, EventArgs e)
        {
            new frmdrawals().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new frmTransaction().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn Thoát?", "EXIT", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }
    }
}
