using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Opdracht_9
{
    public void Start()
    {

        List<Weapons> weapons = new List<Weapons>()
        {
            new Weapons("Goude Prikker", 10, "Zwaard"),
            new Weapons("Glock", 30, "Geweer"),
            new Weapons("Spear", 15, "Zwaard"),
        };

        CallStats(weapons);
        Console.WriteLine("----------------"); // Only for readability

        Random rnd = new Random();
        foreach (Weapons weapon in weapons)
        {
            weapon.UpgradeItem(rnd.Next(1, 10 + 1));
        }

        CallStats(weapons);

    }

    private void CallStats(IEnumerable<Weapons> weapons)
    {
        foreach (Weapons weapon in weapons)
        {
            weapon.ShowStats();
        }
    }
}
