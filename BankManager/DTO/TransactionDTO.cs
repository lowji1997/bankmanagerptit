using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManager.DTO
{
   public interface viewTrantionDTO
    {
        int TransactionId { get; set; }
        int Account { get; set; }
        DateTime Time { get; set; }
        decimal Amount { get; set; }
        decimal Fee { get; set; }
        decimal Total { get; set; }
        int Type { get; set; }
        int ReceiptId { get; set; }

    }
   public class TransactionDTO:viewTrantionDTO
    {
        int _TransactionId;
        public int TransactionId
        {
            get { return _TransactionId; }
            set { _TransactionId = value; }
        }
        int _AccountId;
        public int Account
        {
            get { return _AccountId; }
            set { _AccountId = value; }
        }
        int _UserId;
        public int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        int _CustomerId;
        public int CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
        }
        DateTime _Time;
        public DateTime Time
        {
            get { return _Time; }
            set { _Time = value; }
        }
        decimal _Amount;
        public decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
        decimal _Fee;
        public decimal Fee
        {
            get { return _Fee; }
            set { _Fee = value; }
        }
        decimal _Total;
        public decimal Total
        {
            get { return _Total; }
            set { _Total = value; }
        }
        int _Type;
        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        int _Status;
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public int ReceiptId { get; set; }

    }
}
