using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Opdracht_2
{

    private Dictionary<string, locationsStructure> locations = new Dictionary<string, locationsStructure>
    {
        ["hallway"] = new locationsStructure(false, new[] { "living room", "breaker box", "none" }),
        ["bedroom"] = new locationsStructure(true, new[] { "hallway" }),
        ["kitchen"] = new locationsStructure(true, new[] { "hallway" }),
        ["living room"] = new locationsStructure(false, new[] { "hallway", "balcony" }),
        ["breaker box"] = new locationsStructure(false, new[] { "hallway" }),
        ["hospital"] = new locationsStructure(true, new[] { "breaker box" }),
        ["balcony"] = new locationsStructure(false, new[] { "living room" }),
        ["bathroom"] = new locationsStructure(false, new[] { "living room" }),
    };

    public struct locationsStructure
    {
        public bool willLose;
        public string[] neededLocations;

        public locationsStructure(bool _willLose, string[] _neededLocations)
        {
            willLose = _willLose;
            neededLocations = _neededLocations;
        }
    }

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

            if (locations.TryGetValue(currentMove, out locationsStructure data))
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

    bool CheckValidLocation(string location)
    {
        return locations.ContainsKey(location);
    }
}
