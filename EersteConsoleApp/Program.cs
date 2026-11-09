using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EersteConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("'ello ");

            while (true)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "hi":
                        Console.WriteLine("wassup");
                        
                        break;
                    case "shibby":
                        Console.WriteLine("shibby");
                        break;
                    default:
                        Console.WriteLine("Oi you bwuggin' fwam");
                        break;
                }
            }
        }
    }
}
