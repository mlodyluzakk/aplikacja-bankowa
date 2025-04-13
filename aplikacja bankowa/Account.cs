namespace aplikacja_bankowa
{
    public class Account
    {
        public string AccountNumber { get; }
        public double Balance { get; private set; }

        public Account(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
                Balance -= amount;
        }
    }
}
