using System;

namespace BankApp
{
    public class BankAccount
    {
        // Private fields
        private string accountNumber;
        private double balance;

        // Constructor: set account number and initial balance (initial balance must be > 0)
        public BankAccount(string accountNumber, double initialBalance)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
                throw new ArgumentException("Account number cannot be empty.", nameof(accountNumber));

            if (initialBalance <= 0)
                throw new ArgumentException("Initial balance must be greater than 0.", nameof(initialBalance));

            this.accountNumber = accountNumber;
            this.balance = initialBalance;
        }

        // Public property: AccountNumber (get only)
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        // Public property: Balance (get public, set private)
        // The private set ensures outside code cannot directly set balance.
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value <= 0)
                    throw new InvalidOperationException("Balance cannot be set to zero or negative.");
                balance = value;
            }
        }

        // Deposit method: amount must be > 0
        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be greater than 0.", nameof(amount));

            // we update the private field directly
            balance += amount;
        }

        // Withdraw method: amount must be > 0 and <= current balance
        public void Withdraw(double amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdraw amount must be greater than 0.", nameof(amount));

            if (amount > balance)
                throw new InvalidOperationException("Insufficient funds.");

            balance -= amount;
        }
    }
}
