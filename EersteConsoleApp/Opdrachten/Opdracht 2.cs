using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EersteConsoleApp.Opdrachten
{
    internal class Opdracht_2
    {
        bool lost = false;

        void print(string text)
        {
            Console.WriteLine(text);
        }

        public void Start()
        {

            string currentLocation = "none";

            string[] locations = {"hallway", "bedroom",
                "kitchen",
                "living room",
                "bathroom"
            };

            bool checkValidLocation(string location)
            {
                foreach (string l in locations)
                {
                    if (location == l)
                    {
                        return true;
                    }

                    continue;
                }

                return false;
            }

            while (true)
            {
                print(currentLocation);

                if (currentLocation == "none")
                {
                    print("You're in a dark house, you have to reach the bathroom to take a huge 'ish. Your options: Hallway, bedroom, kitchen and living room.");
                    print("Your move?");
                }

                if (currentLocation == "hallway")
                {
                    print("Your options: Bedroom, kitchen and living room.");
                    print("Your move?");
                }

                string currentMove = Console.ReadLine().ToLower();

                if (checkValidLocation(currentMove))
                {
                    currentLocation = currentMove;
                    continue;
                }

                print($"You're in the {currentLocation} now.");
            }
        }
    }
}
