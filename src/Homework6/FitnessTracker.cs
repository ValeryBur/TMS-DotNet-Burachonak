using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Homework6
{
    public class User
    {
        public delegate void del(string str, string str2);
        public event del Notify;

        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public void StepCounter()
        {
            Random randomStepCount = new Random();
            Console.WriteLine($"The number of steps: {randomStepCount.Next(0, 50000)}"); ;
        }
        public void Pulse()
        {
            Random randomPulse = new Random();
            Console.WriteLine($"The pulse / per min: {randomPulse.Next(20, 150)}"); ;
        }
        public void CaloriesCount()
        {
            Random randomCalories = new Random();
            Console.WriteLine($"Calories burned: {randomCalories.Next(0, 10000)}"); ;
        }
        public void RunAction()
        {
            Console.Write("Input minutes count:");
            int runMinutes = UserInput();
            Console.WriteLine($"Wasted calories: {runMinutes * 8}");
            Console.WriteLine($"Steps: {runMinutes * 180}");
        }
        public void WalkAction()
        {
            Console.Write("Input minutes count:");
            int walkMinutes = UserInput();
            Console.WriteLine($"Wasted calories: {walkMinutes * 5}");
            Console.WriteLine($"Steps: {walkMinutes * 60}");
        }
        public void SwimAction()
        {
            Console.Write("Input minutes count:");
            int swimMinutes = UserInput();
            Console.WriteLine($"Wasted calories: {swimMinutes*10}");
            Console.WriteLine($"Meters: {swimMinutes*25}");
        }

        public void UserRegistration()
        {
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("Age: ");
            Age = UserInput();
            Console.Write("Birthdate: ");
            BirthDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Height: ");
            Weight = UserInputWightOrHeight();
            Console.Write("Weight: ");
            Height = UserInputWightOrHeight();
        }
        public static int UserInput()
        {
            string userInput = Console.ReadLine();
            bool canParse = false;
            canParse = int.TryParse(userInput, out int parsedNumber);
            return parsedNumber;
        }
        public static double UserInputWightOrHeight()
        {
            string userInput = Console.ReadLine();
            bool canParse = false;
            canParse = double.TryParse(userInput, out double parsedNumber);
            return parsedNumber;
        }
        public void AutoModeSelected(User user)
        {
            user.StepCounter();
            user.Pulse();
            user.CaloriesCount();
            Notify?.Invoke("+375(29) 123-45-67 has phoned you!", "You've got a message from +375(29) 123-45-67");
        }
        public void HandModeSelected(User user)
        {
            Console.WriteLine("-------Choose action------");
            Console.WriteLine("----- Run ---------|| Press R");
            Console.WriteLine("----- Walk --------|| Press W");
            Console.WriteLine("----- Swim --------|| Press S");
            var key2 = Console.ReadKey().Key;
            if (key2 == ConsoleKey.R)
            {
                Console.WriteLine();
                user.RunAction();
            }
            else if (key2 == ConsoleKey.W)
            {
                Console.WriteLine();
                user.WalkAction();
            }
            if (key2 == ConsoleKey.S)
            {
                Console.WriteLine();
                user.SwimAction();
            }

        }
    }
}
