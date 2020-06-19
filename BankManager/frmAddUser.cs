using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using BankManager.DAL;
using BankManager.DTO;

namespace BankManager
{
    public partial class frmAddUser : Form
    {
        private DataRow customerrow;

        public void SetData(DataRow dr)
        {
          
            textName.Text = dr["FirstName"] + string.Empty;
            textLName.Text = dr["LastName"] + string.Empty;
            textNumber.Text = dr["IDNumber"] + string.Empty;
            textPlace.Text = dr["IDPlace"] + string.Empty;
            textAddress.Text = dr["Address"] + string.Empty;
            textPhone.Text = dr["Phone"] + string.Empty;
        }
       
        public frmAddUser(DataRow dr = null)
        {
            InitializeComponent();
            customerrow = dr;
        }


        private void button8_Click(object sender, EventArgs e)
        {
            Customer ctm = new Customer();
           
         
            if (textName.Text == "")
            {
                MessageBox.Show("Please Enter the First Name", "Confirmation"); return;
            }
            if (textLName.Text == "")
            {
                MessageBox.Show("Please Enter the Last Name", "Confirmation"); return;
            }


            if (textNumber.Text == "")
            {
                MessageBox.Show("Please Enter the idnumber", "Confirmation"); return;
            }

            if (textPlace.Text == "")
            {
                MessageBox.Show("Please Enter the Place", "Confirmation"); return;
            }

            if (textAddress.Text == "")
            {
                MessageBox.Show("Please Enter the Adress", "Confirmation"); return;
            }

            if (textPhone.Text == "")
            {
                MessageBox.Show("Please Enter the Phone Number", "Confirmation"); return;
            }
            if(textPhone.Text!="")
            {
                try
                {
                    int phone = int.Parse(textPhone.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("the phone number must be a number","Confirmation");
                    return;
                }
            }
            if(textPhone.Text!="")
            {
                try
                {
                    UInt64 phone = UInt64.Parse(textPhone.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("Phone number don't contain special characters", "confirmation");
                    return;
                }
            }
           

            string query = @"INSERT INTO Customer (FirstName, LastName, IDNumber, IDPlace, IDDate,Address,Phone) VALUES (@FirstName, @LastName, @IDNumber, @IDPlace, @IDDate,@Address,@Phone)";
            if (customerrow != null)
                query = @"UPDATE Customer SET FirstName = @FirstName, LastName = @LastName, IDNumber = @IDNumber, IDPlace = @IDPlace, IDDate = @IDDate,Address=@Address,Phone=@Phone WHERE CustomerId = @CustomerId";
            var parameters = new Dictionary<string, object>
            {
                 { "FirstName", textName.Text },
                { "LastName", textLName.Text },
                { "IDNumber", textNumber.Text },
                { "IDPlace", textPlace.Text },
                { "IDDate", dateIDDate.Value },
                { "Address", textAddress.Text },
                { "Phone", textPhone.Text }
            };
            if (customerrow != null)
                parameters.Add("CustomerId", (int)customerrow["CustomerId"]);
            var result = SQLProvider.Execute(query, paramters: parameters);
            if (result)
            {
                MessageBox.Show("Save Customer successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Save Customer failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void frmAddUser_Load(object sender,EventArgs e)
        {
            if (customerrow != null)
                SetData(customerrow);
            dateIDDate.MinDate = DateTime.Now;
        }
        private void button7_Click(object sender, EventArgs e)
        {
                
            if(MessageBox.Show("Do you want to exit?","confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
            {
                Close();
            }

        }

      
    }
}
