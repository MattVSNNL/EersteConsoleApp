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

        public void Start()
        {
            Console.WriteLine("Enter your birthdate");
            Console.WriteLine("For example: 03/02/2006 (March 2nd 2006)");

            string birthDateStr = Console.ReadLine();
            
            if (DateTime.TryParseExact(birthDateStr, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthdate))
            {

                int age = CalculateAge(birthdate);
                
                // Console.WriteLine(age);

                if (age < 12)
                {
                    Console.WriteLine($"You're a child, you're {age} years old. You can't vote nor drive.");
                }

                if (age > 12 && age < 18)
                {
                    Console.WriteLine($"You're a teen, you're {age} years old. You're technically allowed to vote and drive in some countries.");
                }

                if (age >= 18)
                {
                    Console.WriteLine($"You're a legal adult, you're {age} years old. You can vote AND drive. (atleast if you have a license)");
                }

                return;
            }

            Console.Clear();
            Console.WriteLine("Not a valid birthday.");
            Start();
        }
    }
}
