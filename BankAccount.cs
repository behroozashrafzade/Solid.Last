using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string Fullname { get; set; }

        public int Balance { get; set; }

        public List<string> Transactions = new ();

        public BankAccount(int accountNumber,string fullname,int balance)

        {
            AccountNumber= accountNumber;
            Fullname= fullname;
            Balance = balance;
            
        }
        public void Deposit(int amount)
        {
            Balance += amount;


            Transactions.Add($"Deposited ${amount}.New Blance :${Balance}");

        }


    }

}
