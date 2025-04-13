namespace aplikacja_bankowa
{
    public class AccountController
    {
        private Account account;
        private AccountView view;

        public AccountController(Account account, AccountView view)
        {
            this.account = account;
            this.view = view;
        }

        public void DepositFunds(double amount)
        {
            account.Deposit(amount);
            view.ShowMessage($"Wpłacono: {amount} zł. Stan konta: {account.Balance} zł.");
        }

        public void WithdrawFunds(double amount)
        {
            if (amount > account.Balance)
            {
                view.ShowMessage("Brak wystarczających środków.");
            }
            else
            {
                account.Withdraw(amount);
                view.ShowMessage($"Wypłacono: {amount} zł. Stan konta: {account.Balance} zł.");
            }
        }

        public void DisplayAccountDetails()
        {
            view.ShowMessage($"Numer konta: {account.AccountNumber}, Stan konta: {account.Balance} zł");
        }
    }
}
