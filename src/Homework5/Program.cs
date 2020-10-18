using System;

namespace Homework5
{
    class Program
    {
        delegate void Info();
        static void Main(string[] args)
        {
            Atm atm = new Atm();
            atm.BalanceHandler += GetInfo;
            atm.BalanceHandler += ColorGetInfo;
            atm.BalanceHandler += (decimal amount, string str) => Console.WriteLine($"Lambda test: {str}, {amount}");
            atm.PutMoney(100);
            atm.GetMoney(50);
            atm.ShowInfo();
            Console.ReadLine();


        }
        public static void GetInfo(decimal amount, string operation)
        {
            Console.WriteLine($"Operation: {operation}. Current balance: {amount}");
        }
        public static void ColorGetInfo(decimal amount, string operation)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Operation: {operation}. Current balance: {amount}");
            Console.ResetColor();
        }

    }
}
