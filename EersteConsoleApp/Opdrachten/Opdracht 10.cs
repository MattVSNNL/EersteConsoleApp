using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

internal class Opdracht_10
{

    public void Start()
    {
        bool running = true;

        Console.WriteLine("Hey! Write any word and I'll tell you if it's a palindrome.");
        Console.WriteLine("A palindrome is basically a word that's the same forwards and backwards.");
        Console.WriteLine("For example: Wow, mom, racecar, Hannah, rotor, radar, etc. Even some Dutch words like lepel, negen, meetsysteem\n");

        while (running)
        {
            Console.WriteLine("Please write any word you want.");

            // Trim white space incase of palindrome words that have spaces in them, like "race car".
            // Also trim punctuation for palindrome sentences like "Madam, I'm Adam"
            string word = Console.ReadLine();
            word = String.Concat(word.Where(c => Char.IsLetterOrDigit(c)));

            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Please write a word.");
                continue;
            }

            if (ReversedWord(word).ToLower() != word.ToLower())
            {
                Console.WriteLine("No, this word isn't a palindrome. Try another word!\n");
                continue;
            }

            Console.WriteLine($"Reversed: {ReversedWord(word)}");
            Console.WriteLine("Yes, This word is a palindrome. You want to try another?\n");
        }
    }

    private string ReversedWord(string text)
    {

        char[] charArray = text.ToLower().ToCharArray();
        Array.Reverse(charArray);

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
        }

        return new string(charArray);
    }
}
