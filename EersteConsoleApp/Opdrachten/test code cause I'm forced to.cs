using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class test_code_cause_I_m_forced_to
{
    public void Start()
    {
        booleans.Reverse();

        numbers.Sort();
        numbers.Reverse();

        fruits.Sort();
        fruits.Reverse();

        foreach(bool boolean in booleans)
        {
            Console.WriteLine(boolean);
        }
        Console.WriteLine();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine();
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }

    private List<bool> booleans = new List<bool>()
    {
        true,
        true,
        false,
        false
    };

    private List<int> numbers = new List<int>()
    {
        5, 2, 9, 4
    };

    private List<string> fruits = new List<string>()
    {
        "Bananum",
        "Strawberrum",
        "Applum"
    };
}
