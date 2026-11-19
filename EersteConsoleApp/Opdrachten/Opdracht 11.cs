using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Opdracht_11
{
    public void Start()
    {
        Console.WriteLine("Are you ready to start!? Type 'ready' when you're ready.");

        string isReady = Console.ReadLine().ToLower();

        if (isReady == "ready")
        {
            int right = 0;
            int wrong = 0;
            bool waiting = false;

            for (int i = 0; i < 5; i++)
            {

                float num1 = GenerateNumber();
                float num2 = GenerateNumber();
                string op = PickOperator();

                RekenQuiz newQuestion = new RekenQuiz(num1, num2, op);
                (float num1, float num2, string op) generatedQuestion = newQuestion.GenerateQuestion();

                Console.WriteLine($"\nWhat is {generatedQuestion.num1} {generatedQuestion.op} {generatedQuestion.num2}?");
                Console.WriteLine("(If a number is a decimal, please round to two decimals)");
                
                waiting = true;

                while (waiting)
                {
                    string answerStr = Console.ReadLine();

                    if (!float.TryParse(answerStr, out float answer))
                    {
                        Console.WriteLine("Please write a number!");
                        continue;
                    }

                    waiting = false;

                    if (!newQuestion.CheckAnswer(answer))
                    {
                        wrong += 1;
                        Console.WriteLine("Wrong!\n");
                        continue;
                    }

                    right += 1;
                    Console.WriteLine("Right!\n");
                    continue;
                }
            }

            Console.WriteLine($"Right: {right}\nWrong: {wrong}\n");

            if (right > wrong)
            {
                Console.WriteLine("Good job, you did well!");
                return;
            }

            Console.WriteLine("Better luck next time!");
            return;
        }

    }

    private Random rng = new Random();
    private string[] operators = { "+", "-", "*", "/" };

    private float GenerateNumber() => rng.Next(1, 10 + 1); // + 1 so we can count 10 too
    private string PickOperator() => operators[rng.Next(operators.Length)];
}
