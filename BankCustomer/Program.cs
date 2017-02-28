using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> trList = new List<string>();
            
            Bank bnk = new Bank();
            Customer cust1 = new Customer();
            Customer cust2 = new Customer();
            Customer cust3 = new Customer();
            Account acc = new Account();

            cust1.Lastname = "Ankka";
            cust1.Firstname = "Aku";
            cust2.Lastname = "Ankka";
            cust2.Firstname = "Iines";
            cust3.Lastname = "Ankka";
            cust3.Firstname = "Tupu";
            cust1.Accountnumber = cust1.Createaccountnumber();
            cust2.Accountnumber = cust2.Createaccountnumber();
            cust3.Accountnumber = cust3.Createaccountnumber();

            Console.WriteLine("Customer: {1} , Account number: {0} ", cust1.Accountnumber, cust1.Lastname + " " + cust1.Firstname );
            Console.WriteLine("Customer: {1} , Account number: {0} ", cust2.Accountnumber, cust2.Lastname + " " + cust2.Firstname);
            Console.WriteLine("Customer: {1} , Account number: {0} ", cust3.Accountnumber, cust3.Lastname + " " + cust3.Firstname);






            Console.ReadKey();

        }
    }
}
