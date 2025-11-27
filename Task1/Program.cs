using System;
using BankApp;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a bank account with account number and initial balance
                BankAccount account = new BankAccount("ACC-12345", 500.00);

                // Display account number and starting balance
                Console.WriteLine("Account Number: " + account.AccountNumber);
                Console.WriteLine("Starting Balance: " + account.Balance);

                // Deposit money
                Console.WriteLine("\nDepositing 200.50...");
                account.Deposit(200.50);
                Console.WriteLine("Balance after deposit: " + account.Balance);

                // Withdraw money
                Console.WriteLine("\nWithdrawing 150...");
                account.Withdraw(150);
                Console.WriteLine("Balance after withdrawal: " + account.Balance);

                // Final balance
                Console.WriteLine("\nFinal Balance: " + account.Balance);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}