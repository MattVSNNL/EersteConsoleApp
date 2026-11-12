using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EersteConsoleApp.Opdrachten
{
    internal class Opdracht_6
    {

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
            Console.WriteLine("To what number do you want to guess?");

            string numberStr = Console.ReadLine();
            var numberVar = IsValidNumber(numberStr);
            int number = numberVar.number;

            if (!numberVar.valid)
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

            while (true)
            {

                string guessedNumberStr = Console.ReadLine();
                var gNumberVar = IsValidNumber(guessedNumberStr);
                int guessedNumber = gNumberVar.number;

                if (!gNumberVar.valid)
                {
                    Console.WriteLine("Not a valid number. Please try again.\n");
                    continue;
                }

                if (guessedNumber != randomNum)
                {
                    Console.WriteLine("\nWrong. Try again :D");
                    errors += 1;

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
}
