using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EersteConsoleApp.Opdrachten
{
    internal class Opdracht_4
    {

        int CalculateAge(DateTime birthdate)
        {
            DateTime today = DateTime.Today;

            int age = today.Year - birthdate.Year;

            if (birthdate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        bool isOverEighteen(int age)
        {
            return age >= 18;
        }

        void PrintAgeCategory(int age)
        {
            bool adult = isOverEighteen(age);

            if (adult && age < 30)
            {
                Console.WriteLine("You're a young adult. You're in your 20s");
            }

            if (adult && age >= 30 && age < 50)
            {
                Console.WriteLine("You're getting older. Start cooking up on that grill unc");
            }

            if (adult && age >= 50)
            {
                Console.WriteLine("You're getting older. Do your dih still work?");
            }
        }

        public void Start()
        {
            Console.WriteLine("Enter your birthdate");
            Console.WriteLine("For example: 03/02/2006 (March 2nd 2006)");

            string birthDateStr = Console.ReadLine();
            
            if (DateTime.TryParseExact(birthDateStr, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthdate))
            {

                int age = CalculateAge(birthdate);

                // Console.WriteLine(age);

                Console.WriteLine($"You're {age} years old.");
                
                if (isOverEighteen(age))
                {
                    Console.WriteLine("You can legally vote");
                }
                else
                {
                    Console.WriteLine("You CAN'T legally vote");
                }

                PrintAgeCategory(age);
                return;
            }

            Console.Clear();
            Console.WriteLine("Not a valid birthday.");
            Start();
        }
    }
}
