using System;
using System.Collections.Generic;
using System.Text;

namespace Homework4
{
    public class Bird : AnimalBase<int>
    {
        public void Fly()
        {
            Console.WriteLine("I belive I can fly");
        }
    }
}
