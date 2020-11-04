using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fitness Tracker!");
            bool inputContinue = true;
            User user = new User();
            user.Notify += CallAndMessageInvoker;
            user.UserRegistration();
            ModeSelector(user, inputContinue);
            Console.ReadLine();
        }

        public static void ModeSelector(User user, bool inputContinue)
        {
            while (inputContinue)
            {
                Console.WriteLine();
                Console.WriteLine("--------- Choose Mode ---------");
                Console.WriteLine("========== Auto mode ==========(Press A)");
                Console.WriteLine("========== Hand mode ==========(Press H)");
                var key = Console.ReadKey().Key;

                Console.WriteLine();
                if (key == ConsoleKey.A)
                {
                    user.AutoModeSelected(user);

                }
                else if (key == ConsoleKey.H)
                {
                    user.HandModeSelected(user);

                    
                }
                inputContinue = InputContinue();
            }
        }

        public static void CallAndMessageInvoker(string missedCall, string message)
        {
            Console.WriteLine(missedCall);
            Console.WriteLine(message);
        }
        public static bool InputContinue()
        {
            Console.Write("Press Y to continue or N to exit...");
            var key = Console.ReadKey().Key;
            if (key == ConsoleKey.Y)
                return true;
            else
                Console.WriteLine();
                Console.WriteLine("Bye Bye!");
                return false;
        }
        public static int UserInput()
        {
            string userInput = Console.ReadLine();
            bool canParse = false;
            canParse = int.TryParse(userInput, out int parsedNumber);
            return parsedNumber;
        }
    }
}
