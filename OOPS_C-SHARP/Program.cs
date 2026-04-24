using System;
namespace encapsulation
{
    public class Bank
    {
        private double balance;

        public double GetBalance()
        {
            return balance;

        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }


    }
    class Program
    {
        public static void Main()
        {
            Bank bank = new Bank();
            bank.SetBalance(500);
            Console.WriteLine(bank.GetBalance());
            Console.ReadKey();

        }
    }
}
