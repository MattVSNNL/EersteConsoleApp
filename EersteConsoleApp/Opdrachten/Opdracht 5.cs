using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EersteConsoleApp.Opdrachten
{
    internal class Opdracht_5
    {
        void PrintTable(int table, int times)
        {
            for (int i = 1; i <= times; i++)
            {
                Console.WriteLine(table * i);
            }
        }

        (bool valid, int number) IsValidNumber(string str)
        {
            int num;

            if (!int.TryParse(str, out num))
            {
                return (false, num);
            }

            return (true, num);
        }

        public void Start()
        {
            Console.WriteLine("What table do you want?");

            string tableStr = Console.ReadLine();

            var tableNum = IsValidNumber(tableStr);
            int table = tableNum.number;

            if (!tableNum.valid)
            {
                Console.Clear();
                Console.WriteLine("Not a valid number. Please try again.");
                Console.WriteLine();
                Start();
            }

            Console.WriteLine();
            Console.WriteLine("What limit do you want?");

            string limitStr = Console.ReadLine();
            var limitNum = IsValidNumber(limitStr);
            int limit = limitNum.number;

            if (!limitNum.valid)
            {
                Console.Clear();
                Console.WriteLine("Not a valid number. Please try again.");
                Console.WriteLine();
                Start();
            }

            Console.WriteLine();
            Console.WriteLine($"The times table of {table}");
            PrintTable(table, limit);
            return;
        }
    }
}
