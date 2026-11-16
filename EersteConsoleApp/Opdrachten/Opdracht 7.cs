using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Opdracht_7
{

    public void Start()
    {

        int[] results = new int[6];

        for (int i = 0; i < 100; i += 1)
        {
            RollDice();
        }

        foreach (int number in numbers)
        {
            results[number - 1] += 1;
        }

        for (int i = 1; i <= 6; i += 1)
        {
            //int num = i + 1;
            double resultNum = (double)results[i - 1] / numbers.Count;
            Console.WriteLine($"{i} was rolled {results[i - 1]} ({resultNum:P0})"); // P0 is apparently a way to format numbers to a percentage, can use P2 if you want 10.00%
        }

        int highestCount = Array.IndexOf(results, results.Max()) + 1;
        Console.WriteLine($"Number most rolled: {highestCount}, with {results[highestCount - 1]} rolls.");
        return;
    }

    private Random rnd = new Random();
    private List<int> numbers = new List<int>();

    private void RollDice()
    {
        numbers.Add(rnd.Next(1, 6 + 1));
    }
}
