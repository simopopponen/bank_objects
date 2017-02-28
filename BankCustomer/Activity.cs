using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomer
{
    class Activity
    {
        private decimal _sum;
        private string _date;
        private string _time;

        public decimal Sum
        {
            get { return _sum; }
            set { _sum = value; }
        }

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Time
        {
            get { return _time; }
            set { _time = value; }
        }
    }
}
