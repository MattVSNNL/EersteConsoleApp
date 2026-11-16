using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Opdracht_3
{
    string chosenWeather;

    public void Start()
    {

        if (chosenWeather == null)
        {
            Console.WriteLine("Wat voor weer is het?");
            Console.WriteLine("Opties: Zonnig, bewolkt of regent");
            string weer = Console.ReadLine().ToLower();

            if (!IsValidWeather(weer))
            {
                Console.Clear();
                Console.WriteLine("Deze weer bestaat niet");
                Start();
                return;
            }

            chosenWeather = weer;
        }

        Console.WriteLine("Wat is de temperatuur buiten?");
        string temperatuurStr = Console.ReadLine();

        if (!int.TryParse(temperatuurStr, out int temperatuur))
        {
            Console.WriteLine("Temperatuur moet een nummer zijn");
            Start();
            return;
        }

        if (chosenWeather == "regent")
        {
            if (temperatuur >= 5)
            {
                Console.WriteLine("Je hebt echt wel een jas nodig vandaag..");
                return;
            }
            else if (temperatuur < 5)
            {
                Console.WriteLine("Blijf gewoon binnen");
                return;
            }
        }

        if (chosenWeather == "bewolkt")
        {
            if (temperatuur >= 10)
            {
                Console.WriteLine("Je hebt echt wel een jas nodig vandaag..");
                return;
            }
            else if (temperatuur < 10)
            {
                Console.WriteLine("Je hebt een jas nodig, en een sjaal.");
                return;
            }
        }

        if (chosenWeather == "zonnig")
        {
            if (temperatuur >= 20)
            {
                Console.WriteLine("Je hebt geen jas nodig vandaag geniet lekker van de zon!");
                return;
            }
            else if (temperatuur < 20)
            {
                Console.WriteLine("Je hebt echt wel een jas nodig vandaag.. Maar zonnebrand kan alsnog verstandig zijn!");
                return;
            }
        }
    }

    string[] weren = {"regent", "zonnig", "bewolkt"};

    private bool IsValidWeather(string weer)
    {
        foreach(string weather in weren)
        {
            if (weather == weer)
            {
                return true;
            }
        }
        return false;
    }
}
