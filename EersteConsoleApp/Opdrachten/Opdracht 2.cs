using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Opdracht_2
{

    public void Start()
    {
        string currentLocation = "none";
        bool lost = false;

        while (true)
        {

            if (currentLocation == "none")
            {
                Console.WriteLine("You're in a dark house, you have to reach the bathroom to take a huge 'ish.");
                Console.WriteLine("Your options: Hallway.");
                Console.WriteLine("Your move?");
            }

            if (currentLocation == "hallway")
            {
                Console.WriteLine("Now you're in the hallway.");
                Console.WriteLine("Your options: Bedroom, kitchen and living room.");
                Console.WriteLine("Your move?");
            }

            if (currentLocation == "bedroom")
            {
                Console.WriteLine("You went to the bedroom. You got so sleepy, you fell asleep onto your comfy bed. When you wake up, you're covered in shit.");
                Console.WriteLine("Would you like to try again? Type 'retry' to retry");
            }

            if (currentLocation == "kitchen")
            {
                Console.WriteLine("You went to the kitchen. You notice a delicious looking apple pie on the counter. You can't help but indulge. After you devour that thing like a fat fuck, you remebered what you were really looking for...but it was too late...");
                Console.WriteLine("Would you like to try again? Type 'retry' to retry");
            }

            if (currentLocation == "bathroom")
            {
                Console.WriteLine("You get to the bathroom and take the most satisfying, heart throbbing, absolute biggest shit known to mankind. It's like you're shitting softballs right out of your asshole. You eat the apple pie that was on the counter in the kitchen, and you shit more, at this point you could package them up and sell them in a six pack. You run out of toilet paper, so you use the house owner's loofa, you stick it in your ass and you look like a little bunny rabbit just making little rabbit turds. At this point, the owner better install a brace bar for the toilet from the ceiling down, like a rollercoaster so you can hold onto it.");
                Console.WriteLine("Congrats you won!");
                break;
            }

            if (currentLocation == "living room")
            {
                Console.WriteLine("You went to the living room");
                Console.WriteLine("Your options: Bathroom");
                Console.WriteLine("Your move?");
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
                    Console.WriteLine("Command not found. You lost.");
                    continue;
                }

                Console.WriteLine("You can't do that. Please try a new command!");
                continue;
            }

            foreach (KeyValuePair<string, (bool willLose, string neededLocation)> location in locations)
            {
                if (location.Key == currentMove)
                {
                    if (location.Value.neededLocation != "any" && location.Value.neededLocation != currentLocation)
                    {
                        Console.WriteLine("You can't do that. Please try a new command!");
                        continue;
                    }

                    currentLocation = currentMove;

                    if (location.Value.willLose)
                    {
                        lost = true;
                    }
                    break;
                }
            }
        }
    }

    private Dictionary<string, (bool willLose, string neededLocation)> locations = new Dictionary<string, (bool, string)>
    {
        ["hallway"] = (false, "any"),
        ["bedroom"] = (true, "hallway"),
        ["kitchen"] = (true, "hallway"),
        ["living room"] = (false, "hallway"),
        ["bathroom"] = (false, "living room"),
    };

    bool checkValidLocation(string location)
    {
        return locations.ContainsKey(location);
    }
}
