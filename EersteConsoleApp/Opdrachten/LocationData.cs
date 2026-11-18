using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class LocationData
{
    public static Dictionary<string, Action> locationData = new Dictionary<string, Action>()
    {
        ["none"] = () => {
            Console.WriteLine("You're in a dark house, you have to reach the bathroom to take a huge 'ish.");
            Console.WriteLine("Your options: Hallway.");
            Console.WriteLine("Your move?\n");
        },

        ["hallway"] = () => {
            Console.WriteLine("Now you're in the hallway.");
            Console.WriteLine("Your options: Bedroom, kitchen and living room.");
            Console.WriteLine("Your move?\n");
        },

        ["bedroom"] = () => {
            Console.WriteLine("You went to the bedroom. You got so sleepy, you fell asleep onto your comfy bed. When you wake up, you're covered in shit.");
            Console.WriteLine("Would you like to try again? Type 'retry' to retry\n");
        },

        ["kitchen"] = () => {
            Console.WriteLine("You went to the kitchen. You notice a delicious looking apple pie on the counter. You can't help but indulge. After you devour that thing like a fat fuck, you remebered what you were really looking for...but it was too late...");
            Console.WriteLine("Would you like to try again? Type 'retry' to retry\n");
        },

        ["bathroom"] = () => {
            Console.WriteLine("You get to the bathroom and take the most satisfying, heart throbbing, absolute biggest shit known to mankind. It's like you're shitting softballs right out of your asshole. You eat the apple pie that was on the counter in the kitchen, and you shit more, at this point you could package them up and sell them in a six pack. You run out of toilet paper, so you use the house owner's loofa, you stick it in your ass and you look like a little bunny rabbit just making little rabbit turds. At this point, the owner better install a brace bar for the toilet from the ceiling down, like a rollercoaster so you can hold onto it.");
            Console.WriteLine("Congrats you won!\n");
        },

        ["living room"] = () => {
            Console.WriteLine("You went to the living room");
            Console.WriteLine("Your options: Bathroom, hallway or the balcony");
            Console.WriteLine("Your move?\n");
        },

        ["balcony"] = () => {
            Console.WriteLine("You went to the balcony. Nothing really to see here, just a beautiful sky you can't see cause it's dark.");
            Console.WriteLine("Your options: Living room");
            Console.WriteLine("Your move?\n");
        },

    };
}
