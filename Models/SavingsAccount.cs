namespace BankApp.Models
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; private set; }

        public SavingsAccount(string accountNumber, string ownerName, decimal balance, decimal interestRate = 0.05m)
            : base(accountNumber, ownerName, balance)
        {
            if (interestRate < 0)
                throw new ArgumentException("Процентная ставка не может быть отрицательной.");

            InterestRate = interestRate;
        }

        public override void DisplayInfo()
        {
            decimal calculatedBalance = Balance + (Balance * InterestRate);

            Console.WriteLine("Сберегательный счет");
            Console.WriteLine($"Номер счета: {AccountNumber}");
            Console.WriteLine($"Владелец: {OwnerName}");
            Console.WriteLine($"Текущий баланс: {Balance:F2}");
            Console.WriteLine($"Баланс с процентами: {calculatedBalance:F2}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
