using System;
namespace BankEncapsulation
{
    public class dustinIsAccount
    {
        public dustinIsAccount()
        {
        }

        private double balanece = 0;

        public void Deposit(double amount)
        {
            balanece = amount;
        }

        public double GetBalance()
        {
            return balanece; 
        }
    }
}
