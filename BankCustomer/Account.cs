using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomer
{
    class Account
    {
        private string _accountnumber;
        private decimal _saldo;
        private string _sum;

        public string Accountnumber
        {
            get { return _accountnumber; }
            set { _accountnumber = value; }
        }

        public decimal Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public void GetAllActivities()
        {

        }

        public void GetActivitiesDateBetween()
        {

        }

        public void GetSaldo()
        {

        }

        public string InsertActivity(string Accountnumber )
        {
            

            return _sum;
        }
    }
}
