using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal enum Colers
    {
        Red = 1,
        Green,
        Blue,

    }
    public class ColorPrinter
    {
        public void PrintColors()
        {
            Console.WriteLine("Enter your Colors:");
            String? colorInput = Console.ReadLine();
            Colers color;
            if (Enum.TryParse(colorInput, true, out color))
            {
                switch (color)
                {
                    case Colers.Red:
                        Console.WriteLine("You selected Red color.");
                        break;
                    case Colers.Green:
                        Console.WriteLine("You selected Green color.");
                        break;
                    case Colers.Blue:
                        Console.WriteLine("You selected Blue color.");
                        break;
                    default:
                        Console.WriteLine("Unknown color.");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Invalid color input.");
            }
        }
    }
}
