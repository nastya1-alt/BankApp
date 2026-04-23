namespace BankApp.Models
{
    public abstract class BankAccount
    {
        public string AccountNumber { get; protected set; }
        public string OwnerName { get; protected set; }
        public decimal Balance { get; protected set; }

        protected BankAccount(string accountNumber, string ownerName, decimal balance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
        }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public abstract void DisplayInfo();
    }
}
