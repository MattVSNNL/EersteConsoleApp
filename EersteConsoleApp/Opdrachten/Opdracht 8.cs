using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Opdracht_8
{
    public void Start()
    {
        List<Player> players = new List<Player>()
        {
            new Player("Speler1", 5, 2),
            new Player("Speler2", 10, 3),
            new Player("Speler3", 15, 4)
        };

        foreach (Player player in players)
        {
            player.ShowStats();
        }

    }
}
