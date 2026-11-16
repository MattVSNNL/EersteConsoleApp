using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Opdracht_5
{
    public void Start()
    {
        Console.WriteLine("What table do you want?");

        string tableStr = Console.ReadLine();
        int table;

        if (!int.TryParse(tableStr, out table))
        {
            Console.Clear();
            Console.WriteLine("Not a valid number. Please try again.");
            Console.WriteLine();
            Start();
            return;
        }

        Console.WriteLine();
        Console.WriteLine("What limit do you want?");

        string limitStr = Console.ReadLine();
        int limit;

        if (!int.TryParse(limitStr, out limit))
        {
            Console.Clear();
            Console.WriteLine("Not a valid number. Please try again.");
            Console.WriteLine();
            Start();
            return;
        }

        Console.WriteLine();
        Console.WriteLine($"The times table of {table}");

        for (int i = 1; i <= limit; i++)
        {
            Console.WriteLine(table * i);
        }

        return;
    }
}