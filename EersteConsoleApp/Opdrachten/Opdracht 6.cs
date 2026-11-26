using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Opdracht_6
{

    public void Start()
    {
        Console.WriteLine("To what number do you want to guess?");

        string numberStr = Console.ReadLine();
        int number;

        if (!int.TryParse(numberStr, out number))
        {
            Console.Clear();
            Console.WriteLine("Not a valid number. Please try again.\n");
            Start();
            return;
        }

        if (number <= 1)
        {
            Console.Clear();
            Console.WriteLine("Number needs to be higher than 1. Please try again.\n");
            Start();
            return;
        }

        int randomNum = new Random().Next(1, number + 1);
        int errors = 0;

        Console.WriteLine("\nOkay, I got a number. Guess!");

        bool running = true;
        while (running)
        {

            string guessedNumberStr = Console.ReadLine();

            if (!int.TryParse(guessedNumberStr, out int guessedNumber))
            {
                Console.WriteLine("Not a valid number. Please try again.\n");
                continue;
            }

            if (guessedNumber != randomNum)
            {
                errors += 1;
                Console.WriteLine("\nWrong. Try again :D");
                Console.WriteLine($"Aantal pogingen: {errors}");

                if (errors >= 3)
                {
                    string result = "Lower";

                    if (randomNum > guessedNumber)
                    {
                        result = "Higher";
                    }

                    Console.WriteLine($"(Hint: {result})");
                }

                continue;
            }

            Console.WriteLine("\nCorrect! Congrats. You won.");
            break;
        }

    }
}
