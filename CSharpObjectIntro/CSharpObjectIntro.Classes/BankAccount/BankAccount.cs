using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpObjectIntro.Classes.BankAccount
{
    public class BankAccount
    {
        // As you complete each task make sure you test your code carefully
        // Choose some combination of manual testing, Debug.Assert and unit tests


        // Task One        
        // The bank account should have a balance property        
        // It should have a constructor that sets the initial balance (default zero) and the opening date (default today)
        // It should have methods to deposit and withdraw/make payments from the account. 
        //Making Properties 

        public DateOnly OpeningDate { get; private set; }
        public decimal current_balance { get; private set; }
        public decimal withdraw { get; private set; }
        public decimal deposit { get; private set; }
        public decimal overdraft { get; private set; }

        //Constructer
        public BankAccount(DateOnly openingDate, decimal balance)
        {
            OpeningDate = openingDate;
            current_balance = balance;
        }
        public decimal Withdraw(decimal amount)
        {
            current_balance -= amount;
            if (amount > overdraft)
            {
                throw new Exception("Transaction failed");
            }

            return current_balance;
        }
        public decimal Deposit(decimal amount)
        {
            current_balance += amount;
            return current_balance;
        }
        public void Overdraft(decimal amount)
        {
            overdraft = amount;
        }



        // Task Two
        // Give the option to set an overdraft limit
        // Do not allow a withdrawal/payment if the overdraft limit is exceeded. You could return false or throw an exception.

        //Done


        // Task Three
        // Create a new class called CreditTransaction.
        // It could contain properties such as
        // date, amount, category, counterparty, transactionType, description (optional)
        // e.g 26/09/2022 16:45, -300, Groceries, Waitrose, Card, Weekly shop
        //     27/09/2022 17:40, 200, Gift, Bob Smith, Cheque, Birthday present
        // You might wish to use enums for category and transactionType
        // Amend your bank account to contain a list of transactions
        // The methods for  deposit and withdraw/make payments should be amended to add transactions


        class CreditTransaction
        {
            public DateTime Date { get; set; }
            public double Amount { get; set; }
            public string Category { get; set; }
            public string Counterparty { get; set; }
            public string TransactionType { get; set; }
            public string Description { get; set; }

            public CreditTransaction(DateTime date, double amount, string category, string counterparty, string transactionType, string description = "")
            {
                Date = date;
                Amount = amount;
                Category = category;
                Counterparty = counterparty;
                TransactionType = transactionType;
                Description = description;
            }
        }
        private List<CreditTransaction> Transactions = new List<CreditTransaction>();

        public void AddTransaction(DateTime date, double amount, string category, string counterparty, string transactionType, string description = "")
        {
            Transactions.Add(new CreditTransaction(date, amount, category, counterparty, transactionType, description));
        }

        // Task Four
        // Now add some new methods to your account
        // - See what the balance was at a previous date
        // - See how much money was spent in a given time period
        // - See how much money was spent in different categories

        public double checkBalanceAtDate(DateTime date)
        {
            foreach (CreditTransaction transaction in Transactions)
            {
                if (transaction.Date == date)
                {
                    return transaction.Amount;
                }
            }
            return 0;
        }
        // Extension
        // Work out how much interest is payable on your account
        // For the moment make up the interest rates, though later we could look at loading them from a website
        // The interest should be added as transactions to your account





    }

}
