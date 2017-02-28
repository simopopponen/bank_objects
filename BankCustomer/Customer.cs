using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomer
{
    class Customer
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
            return "Blaah";
        }

        public string Createaccountnumber()
        {
            Bank bnk = new Bank();
            _accountnumber = bnk.Createnewaccount();       
            return _accountnumber;
        }
    }
}
