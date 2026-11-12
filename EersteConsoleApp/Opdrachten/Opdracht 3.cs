using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EersteConsoleApp.Opdrachten
{
    internal class Opdracht_3
    {

        public void Start()
        {
            Console.WriteLine("Wat voor weer is het?");

            string weer = Console.ReadLine().ToLower();

            if (weer == "regent")
            {
                Console.WriteLine("Je hebt echt wel een jas nodig vandaag..");
                return;
            }

            if (weer == "bewolkt")
            {
                Console.WriteLine("Je hebt echt wel een jas nodig vandaag..");
                return;
            }

            if (weer == "zonnig")
            {
                Console.WriteLine("Wat is de temperatuur buiten?");
                string temperatuurStr = Console.ReadLine();
                int temperatuur;

                if (!int.TryParse(temperatuurStr, out temperatuur))
                {
                    Console.Clear();
                    Console.WriteLine("Temperatuur moet een nummer zijn");
                    Start();
                    return;
                }

                if (temperatuur >= 20)
                {
                    Console.WriteLine("Je hebt geen jas nodig vandaag geniet lekker van de zon!");
                    return;
                }
                else if(temperatuur < 20)
                {
                    Console.WriteLine("Je hebt echt wel een jas nodig vandaag.. Maar zonnebrand kan alsnog verstandig zijn!");
                    return;
                }
            }

            Console.Clear();
            Console.WriteLine("Geen bestaande weer");
            Start();
        }
    }
}
