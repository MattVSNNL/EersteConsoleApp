using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EersteConsoleApp
{
    internal class Opdracht_1
    {
        public void Start() {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            Console.WriteLine("What is your age?");

            string age = Console.ReadLine();
            Console.WriteLine($"Your name is {name} and you're {age} years old.");

        }
    }
}
