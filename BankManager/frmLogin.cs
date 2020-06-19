using BankManager.DAL;
using BankManager.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManager.DTO;

namespace BankManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtUsername.SelectionStart = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
             var user = SQLProvider.Single(@"SELECT UserId, FirstName, LastName, Type FROM [dbo].[User] WHERE Username = @Username AND Password = @Password", CommandType.Text, new Dictionary<string, object>
              {
                { "Username", username },
                { "Password", password },

             });
            //var user = SQLProvider.Single(@"SELECT UserId, FirstName, LastName, Type FROM [dbo].[User] where Username = '" + username + "'and Password = '" + password + "'");
            if (user != null)
            {
                Program.UserId = int.Parse(user["UserId"] + string.Empty);
                SessionDTO.UserLogin = new Models.UserDTO
                {
                    UserId = int.Parse(user["UserId"] + string.Empty),
                    FirstName = user["FirstName"] + string.Empty,
                    LastName = user["LastName"] + string.Empty,
                    Type = (UserType)Convert.ToInt32(user["Type"])
                };
                if (SessionDTO.UserLogin.Type == Models.Enums.UserType.CUSTOMER)
                {
                    var account = SQLProvider.Single(@"select AccountId , CustomerId from Account where CustomerId = (select CustomerId from [dbo].[User] where UserId = @UserId )", CommandType.Text, new Dictionary<string, object>
                         {
                            { "UserId", Program.UserId }
                         });
                    Program.AccountId = int.Parse(account["AccountId"] + string.Empty);
                    Program.CustomerId = int.Parse(account["CustomerId"] + string.Empty);
                }

                DialogResult = DialogResult.OK;

            }
            else MessageBox.Show("Username or password is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmCofirmation().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Muốn Thoát?", "EXIT", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Dispose();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        int thaydoi = 0;
        string s = "";
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.ForeColor = Color.Black;
            if (thaydoi == 0)
            {
                thaydoi = 1;
                s += txtUsername.Text;
                txtUsername.Text = "";
                try
                {
                    txtUsername.Text = s.Substring(0, 1);
                }
                catch (ArgumentOutOfRangeException)
                {

                }

            }
            else if (txtUsername.Text == "" && thaydoi == 2)
            {
                txtUsername.Text = "Nhập Tên Đăng Nhập";
                txtUsername.Tag = "";
                txtUsername.ForeColor = Color.Gray;
                txtUsername.SelectionStart = 0;
                thaydoi = 0;
                s = "";
            }
            else
            {
                thaydoi = 2;
                txtUsername.SelectionStart = txtUsername.Text.Length;
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Nhập Tên Đăng Nhập")
            {
                txtUsername.SelectionStart = 0;
            }
            else
            {
                txtUsername.SelectionStart = txtUsername.Text.Length;
            }
            int thaydoi = 0;
            string s = "";
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.ForeColor = Color.Black;
            if (thaydoi1 == 0)
            {
                s1 += txtPassword.Text;
                thaydoi1 = 1;
                txtPassword.Text = "";
                try
                {
                    txtPassword.Text = s1.Substring(0, 1);
                }
                catch (ArgumentOutOfRangeException)
                {

                }

            }
            else if (txtPassword.Text == "" && thaydoi1 == 2)
            {
                txtPassword.Text = "Nhập Mật Khẩu";
                txtPassword.Tag = "";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.SelectionStart = 0;
                thaydoi1 = 0;
                s1 = "";
            }
            else
            {
                thaydoi1 = 2;
                txtPassword.SelectionStart = txtPassword.Text.Length;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Nhập Mật Khẩu")
            {
                txtPassword.SelectionStart = 0;
            }
            else
            {
                txtPassword.SelectionStart = txtPassword.Text.Length;
            }
        }
        string s1 = "";
        int thaydoi1 = 0;

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Nhập Mật Khẩu";
                txtPassword.ForeColor = Color.Gray;
                thaydoi1 = 0;
                s1 = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Formloginchange dmk = new Formloginchange();
            dmk.ShowDialog();
            Login_Load(sender, e);
        }
    }
    }

