using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoBank
{
    public class BankAccount
    {
        private static int accountNumberSeed = 1234567890;

        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get
            {
                decimal balance = 0;
                foreach (var item in transactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
         }

        public BankAccount(string owner, decimal initialBalance)
        {
            Owner = owner;
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        private List<Transaction> transactions = new List<Transaction>();

        public void MakeDeposit(decimal amount, DateTime dateTime, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, dateTime, note);
            transactions.Add(deposit);
            Console.WriteLine($"Amount Deposited {deposit.Amount}");
        }

        public void MakeWithdrawal(decimal amount, DateTime dateTime, string note)
        {
            if (amount <= 0 )
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, dateTime, note);
            transactions.Add(withdrawal);
            Console.WriteLine($"Amount Withdrawn {withdrawal.Amount}");

        }

        public string GetTransactionHistory()
        {
            var report = new StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in transactions)
            {
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }
            report.AppendLine();
            report.AppendLine($"Balance for transaction is { Balance }");
            return report.ToString();
        }
       
    }
}
