using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Weapons
{

    private string _name;
    private int _damage;
    private string _type;

    public Weapons(string name, int damage, string type)
    {
        _name = name;
        _damage = damage;
        _type = type;

        Console.WriteLine(_name);
        Console.WriteLine(_damage);
        Console.WriteLine(_type);
        Console.WriteLine();
    }

    public void ShowStats()
    {
        Console.WriteLine($"{_name} doet {_damage} damage. De wapen's type is een {_type}");
    }

    public void UpgradeItem(int damageToAdd)
    {
        if (damageToAdd <= 0)
            return;

        _damage += damageToAdd;
    }

}
