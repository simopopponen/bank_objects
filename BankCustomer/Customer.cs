using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomer
{
    public class Customer
    {
        private string _firstname;
        private string _lastname;
        private string _accountnumber;

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string Accountnumber
        {
            get { return _accountnumber; }
            set { _accountnumber = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}\t({2})", _firstname, _lastname, _accountnumber);
        }

        public string Createaccountnumber()
        {
            Bank bnk = new Bank("Ankallispankki");
            _accountnumber = bnk.CreateAccountNumber();       
            return _accountnumber;
        }

        public Customer(string firstname, string lastname, string accountnumber)
        {
            _firstname = firstname;
            _lastname = lastname;
            _accountnumber = accountnumber;

        }
}
}
