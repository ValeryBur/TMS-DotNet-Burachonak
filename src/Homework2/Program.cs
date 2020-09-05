using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Попытался сделать свой вариант, но без учета эксепшн
            Console.WriteLine("Please, enter your date: ");
            Console.Write("Please, pick the year number: ");
            string year = Console.ReadLine();
            int x = int.Parse(year);
            Console.Write("Please, pick the month number: ");
            string month = Console.ReadLine();
            int y = int.Parse(month);
            Console.Write("Please, pick the day number: ");
            string day = Console.ReadLine();
            int z = int.Parse(day);
            DateTime pickDate = new DateTime(x, y, z);
            Console.WriteLine($"This day is: {pickDate.DayOfWeek}");
            Console.WriteLine("put any key to find out today's date and time");
            Console.ReadLine();
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("-------------------------------------------------------");
            //конец программы

            Console.Write("Enter your date: ");
            string userInput = Console.ReadLine();
            bool result = DateTime.TryParse(userInput, out DateTime date);
            if (result)
            {
                Console.WriteLine(date.DayOfWeek);
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
            Console.ReadLine();
        }
    }
}