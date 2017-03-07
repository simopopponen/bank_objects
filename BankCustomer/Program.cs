using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Convert;

namespace BankCustomer
{
    public class Program
    {
        static void Main(string[] args)
        {
            //This code is based to Ville Arola's code!!! I just tried to understand what has been done....
            //This has been hard for me to understand because the data is stored to memory, not in database or txt -file etc... :)
            Bank bnk = new Bank("Ankallispankki");
            List<Customer> customers = new List<Customer>();

            //Create list of customers and accounts

            customers.Add(new Customer("Pentti", "Kekkonen", bnk.CreateAccountNumber()));
            customers.Add(new Customer("Juntti", "Makkonen", bnk.CreateAccountNumber()));
            customers.Add(new Customer("Antti", "Kukkonen", bnk.CreateAccountNumber()));

            foreach (Customer t in customers)
            {
                WriteLine("Customer: {0} {1}  Account: {2}", t.Lastname, t.Firstname,
                    t.Accountnumber);
            }

            ReadKey();

            Random rnd = new Random();

            //Create random transactions to accounts
            for (int i = 0; i < 50; i++)
            {
                
                int c = rnd.Next(0, customers.Count()),
                    day = rnd.Next(1, 29),
                    month = rnd.Next(1, 13),
                    year = rnd.Next(2015, 2017);
                double s = rnd.NextDouble() * 2000 - 900;


                //Add transaction to memory...
                bnk.AddTransactionForCustomer(customers[c].Accountnumber,
                    new Transaction(s, new DateTime(year, month, day)));

            }

            ReadKey();

            //Print customer's balance...
            foreach (Customer t in customers)
            {
                PrintBalance(bnk, t);
            }
            //Print customer's transactions...
            foreach (Customer t in customers)
            {
                PrintTransactions(bnk.GetTransactionsForCustomer(t.Accountnumber), t);
            }
            
            ReadKey();
        }

        static void PrintBalance(Bank bank, Customer customer)
        {
            var balance = bank.GetBalanceForCustomer(customer.Accountnumber);
            WriteLine("{0} - balance: {1}{2:0.00}", customer.ToString(), balance >= 0 ? "+" : "", balance);
        }

        
        static void PrintTransactions(List<Transaction> transactions, Customer customer)
        {
            WriteLine("Tilitapahtumat ({0} {1}):", customer.Firstname, customer.Lastname);
            for (int i = 0; i < transactions.Count(); i++)
            {
                WriteLine("{0}\t{1}{2:0.00}", transactions[i].TimeStamp.ToShortDateString(),
                    transactions[i].Sum >= 0 ? "+" : "", transactions[i].Sum);
            }
            WriteLine("\n");
        }
    }
}

