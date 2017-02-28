using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankCustomer
{
    class Bank
    {
        private string _bankname;
        private string _newaccount;
        Random rnd = new Random();


        public string Createnewaccount()
        {
            _newaccount = "FI";
 
            for (int i = 0; i < 16; i++)
            {
                Thread.Sleep(1);
                _newaccount = _newaccount + rnd.Next(9);
            }

            return _newaccount;
        }

        public string Bankname
        {
            get { return _bankname; }
            set { _bankname = value; }
        }

        public void Getsaldo()
        {

        }
    }
}
