using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Player
{
    private string _name;
    private int _level;
    private int _lives;

    public Player(string name, int level, int lives)
    {
        _name = name;
        _level = level;
        _lives = lives;
    }

    public void ShowStats()
    {
        Console.WriteLine($"Naam: {this._name}\nLevel: {this._level}\nLives: {this._lives}\n");
    }
}
