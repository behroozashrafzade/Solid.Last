
using SRP;

BankAccount account = new BankAccount(101, "ashrafzade", 1000000);
account.Deposit(500000000);
account.Withdraw(50000);
Console.WriteLine($"Transaction for accounty : {account.AccountNumber} is : ");
Print print = new Print();

print.PrintTransactions(account.Transactions);


Console.ReadKey();
