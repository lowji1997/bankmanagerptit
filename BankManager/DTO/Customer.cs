using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager.DTO
{
    public class Customer
    {
        string _CustomerId;
        public string customerid
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
        }
        string _FirstName;
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        string _IDNumber;
        public string IDNumber
        {
            get { return _IDNumber; }
            set { _IDNumber = value; }
        }
        string _IDPlace;
        public string IDPlace
        {
            get { return _IDPlace; }
            set { _IDPlace = value; }
        }
        string _Adress;
        public string Adress
        {
            get { return _Adress; }
            set { _Adress = value; }
        }
        string _Phone;
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }

    }
}
