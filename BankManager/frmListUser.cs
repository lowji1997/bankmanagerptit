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

namespace BankManager
{
    public partial class frmListUser : Form
    {
        private void LoadCustomer(string keyword = null)
        {
            var customers = SQLProvider.Query(@"SELECT CustomerId, FirstName, LastName, IDNumber, IDPlace, IDDate, Address, Phone FROM [dbo].[Customer]
                WHERE 1 = 1
                  AND (ISNULL(@Keyword, '') = '' OR FirstName LIKE CONCAT('%', @Keyword, '%')
                                                 OR LastName LIKE CONCAT('%', @Keyword, '%')
                                                 OR Phone LIKE CONCAT('%', @Keyword, '%')
                                                 )",
                  paramters: new Dictionary<string, object>
            {
                { "Keyword", keyword ?? string.Empty }
            });
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataSource = customers;
        }

        public frmListUser()
        {
            InitializeComponent();
        }
        private void frmListUser_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            LoadCustomer();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            new frmAddUser().ShowDialog();
            LoadCustomer();
        }
        private void btnfix_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var customerrow = SQLProvider.Single(@"SELECT CustomerId, FirstName, LastName, IDNumber, IDPlace, IDDate, Address, Phone FROM [dbo].[Customer]
	                WHERE CustomerId = @CustomerId", paramters: new Dictionary<string, object>
                {
                    { "CustomerId", dataGridView1.CurrentRow.Cells[0].Value }
                });
                if (customerrow != null)
                {
                    new frmAddUser(customerrow).ShowDialog();
                    LoadCustomer();
                }

            }   
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btndlt_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (MessageBox.Show("Bạn Muốn Xóa Thông Tin Khách Hàng Này?", "Chú Ý !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var result = SQLProvider.Execute("DELETE FROM [dbo].[Transaction] WHERE CustomerId = @CustomerId;" +
                        "DELETE FROM [dbo].[Account] WHERE CustomerId = @CustomerId; " +
                        "DELETE FROM [dbo].[User] WHERE CustomerId = @CustomerId; " +
                        "DELETE FROM [dbo].[Customer] WHERE CustomerId = @CustomerId; " 
                        , paramters: new Dictionary<string, object>
                    {
                        { "CustomerId", dataGridView1.CurrentRow.Cells[0].Value }
                    });
                    if (result)
                    {
                        //show lên 1 cái form
                        MessageBox.Show("Xóa Thành Công", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCustomer();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không Thành Công", "Lỗi !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  
                }
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer(txtTimkiem.Text);
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            new frmaddatm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmaddacc().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
