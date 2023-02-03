namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var alemansAccount = new BankAccount();
            Console.WriteLine("deposit amount today?");

            var amountToDep = double.Parse(Console.ReadLine());

            alemansAccount.Deposit(amountToDep);

            Console.WriteLine($"your balance is now {alemansAccount.GetBalance()}");
        }
    }
}
