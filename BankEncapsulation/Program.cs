using System;

namespace BankEncapsulation
{
    class MainClass
    {
        private static object dustinIsAccount;

        static void Main(string[] args)
        {

            var dustinIsAccount = new dustinIsAccount();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposite = double.Parse(Console.ReadLine());

            dustinIsAccount.Deposit(amountToDeposite);

            Console.WriteLine($"Thank you! Your balance is now {dustinIsAccount.GetBalance()}");
        }
    }
}
