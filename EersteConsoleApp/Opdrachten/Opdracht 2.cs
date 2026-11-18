using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Opdracht_2
{

    public void Start()
    {
        bool running = true;
        string currentLocation = "none";
        bool lost = false;

        while (running)
        {

            LocationData.locationData[currentLocation]();

            if (currentLocation == "bathroom")
                break;

            string currentMove = Console.ReadLine().ToLower();

            if (!CheckValidLocation(currentMove))
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

            // Check if location exists & is the right location & if you lose

            if (locations.TryGetValue(currentMove, out (bool willLose, string[] neededLocations) data))
            {
                if (!data.neededLocations.Contains(currentLocation))
                {
                    Console.WriteLine("You can't do that. Please try a new command!");
                    continue;
                }
            }

            currentLocation = currentMove;

            if (locations[currentMove].willLose)
            {
                lost = true;
            }
        }
    }

    private Dictionary<string, (bool willLose, string[] neededLocations)> locations = new Dictionary<string, (bool, string[])>
    {
        ["hallway"] = (false, new[] { "living room", "none" }),
        ["bedroom"] = (true, new[] { "hallway" }),
        ["kitchen"] = (true, new[] { "hallway" }),
        ["living room"] = (false, new[] { "hallway", "balcony" }),
        ["balcony"] = (false, new[] { "living room" }),
        ["bathroom"] = (false, new[] { "living room" }),
    };

    bool CheckValidLocation(string location) => locations.ContainsKey(location);
}
