namespace BankApp.Models
{
    public class RegularAccount : BankAccount
    {
        public RegularAccount(string accountNumber, string ownerName, decimal balance)
            : base(accountNumber, ownerName, balance)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Обычный счет");
            Console.WriteLine($"Номер счета: {AccountNumber}");
            Console.WriteLine($"Владелец: {OwnerName}");
            Console.WriteLine($"Баланс: {Balance:F2}");
            Console.WriteLine(new string('-', 30));
        }
    }
}
