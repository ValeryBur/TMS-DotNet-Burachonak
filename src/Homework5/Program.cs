using System;

namespace Homework5
{
    class Program
    {
        delegate void Info();
        static void Main(string[] args)
        {
            Account account1 = new Account(200);
            Account.AccountStateHandler colorDelegate = (new Account.AccountStateHandler(Color_Message));
            account1.RegisterHandler(new Account.AccountStateHandler(Show_Message));
            account1.RegisterHandler(colorDelegate);
            account1.WithDraw(100);
            account1.WithDraw(150);
            account1.UnregisterHandler(colorDelegate);
            account1.Withdraw(50);
            Console.ReadLine();
        }
        private static void Color_Message(string message)
        {
            // Устанавливаем красный цвет символов
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            // Сбрасываем настройки цвета
            Console.ResetColor();
        }
        private static void Show_Message(String message)
        {
            Console.WriteLine(message);
        }
    }
}
