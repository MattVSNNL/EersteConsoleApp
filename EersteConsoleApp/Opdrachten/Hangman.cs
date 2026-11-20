using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Hangman
{
    private bool _started = false;

    public void Start()
    {
        bool running = true;

        if (!_started)
        {
            _started = true;
            Console.WriteLine("Welcome to Hangman! There will be a random word and you have to guess it. You have six(6) guesses before you lose.");
            Console.WriteLine("To start, type 'start' in the console.\n");
        }

        string start = Console.ReadLine().ToLower();

        if (start != "start")
        {
            Console.WriteLine("I'll wait.\n");
            Start();
            return;
        }

        Random rng = new Random();
        List<string> guessedLetters = new List<string>();
        List<string> rightLetters = new List<string>();
        int guesses = 11;
        
        Words word = new Words();
        string randomWord = word.words[rng.Next(word.words.Count)];

        Console.WriteLine("\nAlright! A word is picked. Begin!");

        while (running)
        {
            if (randomWord.ToLower().All(letter => rightLetters.Contains(letter.ToString())))
            {
                Console.WriteLine("\nCongrats! You won!");
                break;
            }

            if (guesses <= 0)
            {
                Console.WriteLine("\nYou lost! Better luck next time");
                Console.WriteLine($"The word was: {randomWord}");
                break;
            }

            Console.WriteLine($"\nGuessed letters: {string.Join(", ", guessedLetters)}");
            Console.WriteLine($"You have {guesses} guesses left\n");
            WriteUnderscoredText(randomWord, rightLetters);
            Console.WriteLine();
            Console.WriteLine();

            string plrLetter = Console.ReadLine().ToLower();

            if (plrLetter.Length != 1)
            {
                Console.WriteLine("Please type a letter!");
                continue;
            }

            if (guessedLetters.Contains(plrLetter))
            {
                Console.WriteLine("You already guessed this letter.");
                continue;
            }

            if (!randomWord.ToLower().Contains(plrLetter))
            {
                Console.WriteLine("Nope!");
                guesses -= 1;
                guessedLetters.Add(plrLetter);
                continue;
            }

            Console.WriteLine("Right!");
            guessedLetters.Add(plrLetter);
            rightLetters.Add(plrLetter);
        }
        
    }

    private void WriteUnderscoredText(string text, List<string> rightLetters)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (rightLetters.Contains(text[i].ToString()))
            {
                Console.Write(text[i]);
                continue;
            }
            Console.Write("_");
        }
    }
}
