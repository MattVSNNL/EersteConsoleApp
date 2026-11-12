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

            Dictionary<string, (bool willLose, string neededLocation)> locations = new Dictionary<string, (bool, string)>
            {
                ["hallway"] = (false, "any"),
                ["bedroom"] = (true, "hallway"),
                ["kitchen"] = (true, "hallway"),
                ["living room"] = (false, "hallway"),
                ["bathroom"] = (false, "living room"),
            };

            //string[] locations = {"hallway", "bedroom",
            //    "kitchen",
            //    "living room",
            //    "bathroom"
            //};

            bool checkValidLocation(string location)
            {
                return locations.ContainsKey(location);
            }

            while (true)
            {
                // print(currentLocation);

                if (currentLocation == "none")
                {
                    print("You're in a dark house, you have to reach the bathroom to take a huge 'ish. Your options: Hallway, bedroom, kitchen and living room.");
                    print("Your move?");
                }

                if (currentLocation == "hallway")
                {
                    print("Now you're in the hallway.");
                    print("Your options: Bedroom, kitchen and living room.");
                    print("Your move?");
                }

                if (currentLocation == "bedroom")
                {
                    print("You went to the bedroom. You got so sleepy, you fell asleep onto your comfy bed. When you wake up, you're covered in shit.");
                    print("Would you like to try again? Type 'retry' to retry");
                }

                if (currentLocation == "kitchen")
                {
                    print("You went to the kitchen. You notice a delicious looking apple pie on the counter. You can't help but indulge. After you devour that thing like a fat fuck, you remebered what you were really looking for...but it was too late...");
                    print("Would you like to try again? Type 'retry' to retry");
                }

                if (currentLocation == "bathroom")
                {
                    print("You get to the bathroom and take the most satisfying, heart throbbing, absolute biggest shit known to mankind. It's like you're shitting softballs right out of your asshole. You eat the apple pie that was on the counter in the kitchen, and you shit more, at this point you could package them up and sell them in a six pack. You run out of toilet paper, so you use the house owner's loofa, you stick it in your ass and you look like a little bunny rabbit just making little rabbit turds. At this point, the owner better install a brace bar for the toilet from the ceiling down, like a rollercoaster so you can hold onto it.");
                    print("Congrats you won!");
                    break;
                }

                if (currentLocation == "living room")
                {
                    print("You went to the living room");
                    print("Your options: Bathroom");
                    print("Your move?");
                }

                string currentMove = Console.ReadLine().ToLower();

                if (!checkValidLocation(currentMove))
                {

                    if (currentMove == "retry" && lost)
                    {
                        currentLocation = "none";
                        lost = false;
                        Console.Clear();
                        continue;
                    }

                    if (lost)
                    {
                        print("Command not found. You lost.");
                        continue;
                    }

                    print("You can't do that. Please try a new command!");
                    continue;
                }

                foreach (var location in locations)
                {
                    if (location.Key == currentMove)
                    {
                        bool locationRight = true;

                        if (location.Value.neededLocation != "any" && location.Value.neededLocation != currentLocation)
                        {
                            locationRight = false;
                            print("You can't do that. Please try a new command!");
                        }
                        if (locationRight)
                        {
                            currentLocation = currentMove;

                            if (location.Value.willLose)
                            {
                                lost = true;
                            }
                        }
                        break;
                    }
                }

            }
        }
    }
}
