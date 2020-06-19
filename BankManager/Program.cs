using BankManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManager
{
    static class Program
    {
        public static int UserId = 0;
        public static int AccountId = 0;
        public static int CustomerId { get;set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login lg = new Login();
            if ((lg.ShowDialog() == DialogResult.OK))
            {   
                if (SessionDTO.UserLogin.Type == Models.Enums.UserType.CUSTOMER)
                    Application.Run(new frmMainCustomer());
                else Application.Run(new frmAdmin());
                //erp    
            }
          
        }
    }
}
