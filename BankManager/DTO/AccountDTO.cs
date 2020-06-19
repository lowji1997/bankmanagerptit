using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManager.DTO.Enums;

namespace BankManager.DTO
{
    public class AccountDTO
    {
        int _AccountId;
        public int AccountId
        {
            get { return _AccountId; }
            set { _AccountId = value; }
        }
        int _AccountNumber;
        public int AccountNumber
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; }
        }
        DateTime _CreateTime;
        public DateTime CreateTime
        {
            get { return _CreateTime; }
            set { _CreateTime = value; }
        }
        int _Type;
        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        int _CustomerId;
        public int CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
        }
        DateTime _ExpireDate;
        public DateTime ExpireDate
        {
            get { return _ExpireDate; }
            set { _ExpireDate = value; }
        }
        StatusAccount _Status;
        public StatusAccount Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        decimal _Money;
        public decimal Money
        {
            get { return _Money; }
            set { _Money = value; }
        }
    }
}
