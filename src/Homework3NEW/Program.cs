using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Homework3NEW
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var backlog = new List<ToDo>();
            var inputStop = false;
            InputBacklogList(backlog, inputStop);
            ShowBacklog(backlog);
            ChangeBacklogTodoItemsStatus(backlog, inputStop);
            ShowBacklog(backlog);

            Console.ReadLine();
        }
        private static void InputBacklogList(List <ToDo> backlog, bool inputStop)
        {
            while (!inputStop)
            {
                Console.WriteLine("Enter name and description.");
                var todo = new ToDo
                {
                    Name = Console.ReadLine(),
                    Description = Console.ReadLine()
                };
                backlog.Add(todo);
                inputStop = InputStop();
                Console.WriteLine();
            }
        }
        private static void ChangeBacklogTodoItemsStatus(List <ToDo> backlog, bool inputStop)
        {
            while(!inputStop)
            {
                Console.WriteLine("Please, enter todo Id");
                var userInput = Console.ReadLine();
                foreach(var todo in backlog)
                {
                    if(todo.GetId() == userInput)
                    {
                        Console.WriteLine("Enter new todo status..");
                        Console.WriteLine("Available statuses: InProgress, Done, Cancelled");
                        var newStatus = Console.ReadLine();
                        todo.SetStatus(todo.ConvertStatus(newStatus));
                    }
                }
                inputStop = InputStop();
                Console.WriteLine();
            }
        }
        private static void ShowBacklog(List<ToDo> backlog)
        {
            Console.WriteLine("=================");
            foreach (var todo in backlog)
                {
                todo.GetInfo();
                }
            Console.WriteLine("=================");
        }
        private static bool InputStop ()
        {
            Console.Write("Stop? Press Y/y");
            var key = Console.ReadKey().Key;
            return key == ConsoleKey.Y;
        }
    }
}
