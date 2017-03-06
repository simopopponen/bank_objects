using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomer
{
    public class Transaction
    {
        private readonly DateTime _timestamp;
        private readonly double _sum;

        public DateTime TimeStamp
        {
            get { return _timestamp; }
        }
        public double Sum
        {
            get { return _sum; }
        }
        public Transaction(double sum, DateTime dateTime)
        {
            _timestamp = dateTime;
            _sum = sum;
        }
    }
}