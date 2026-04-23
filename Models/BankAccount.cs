namespace BankApp.Models
{
    public abstract class BankAccount
    {
        private string _accountNumber;
        private string _ownerName;
        private decimal _balance;

        public string AccountNumber
        {
            get => _accountNumber;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Номер счета не может быть пустым.");
                _accountNumber = value;
            }
        }

        public string OwnerName
        {
            get => _ownerName;
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Имя владельца не может быть пустым.");
                _ownerName = value;
            }
        }

        public decimal Balance
        {
            get => _balance;
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Баланс не может быть отрицательным.");
                _balance = value;
            }
        }

        protected BankAccount(string accountNumber, string ownerName, decimal balance)
        {
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = balance;
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма пополнения должна быть больше нуля.");

            _balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма снятия должна быть больше нуля.");

            if (amount > _balance)
                throw new InvalidOperationException("Недостаточно средств.");

            _balance -= amount;
        }

        public abstract void DisplayInfo();
    }
}
