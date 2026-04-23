using BankApp.Models;

namespace BankApp.Services
{
    public class Bank
    {
        private List<BankAccount> _accounts = new();

        public void AddAccount(BankAccount account)
        {
            if (account == null)
                throw new ArgumentNullException(nameof(account));

            _accounts.Add(account);
        }

        public List<BankAccount> GetAllAccounts()
        {
            return _accounts;
        }

        public void ShowAllAccounts()
        {
            if (_accounts.Count == 0)
            {
                Console.WriteLine("Счетов нет.");
                return;
            }

            foreach (var account in _accounts)
            {
                account.DisplayInfo();
            }
        }
    }
}
