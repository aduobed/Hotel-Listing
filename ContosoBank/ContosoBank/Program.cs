using System.Security.Principal;

namespace ContosoBank
{
    internal class ContosoBank
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Contoso Bank");

            var account = new BankAccount("Kate", 1000);
            //Console.WriteLine($"Account number {account.Number} was created for {account.Owner} with {account.Balance}");
            /*
           

            Console.WriteLine(account.Balance);
            */

            // Test for a negative balance.
            try
            {
                account.MakeDeposit(4000, DateTime.Now, "second deposit");
                account.MakeWithdrawal(3000, DateTime.Now, "second withdrawal");
                account.MakeDeposit(6000, DateTime.Now, "third deposit");
                account.MakeWithdrawal(1200, DateTime.Now, "third deposit");
                Console.WriteLine(account.GetTransactionHistory());
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

        }
    }
}