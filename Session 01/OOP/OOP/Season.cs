using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public enum Season
    {
        spring, 
        summer,
        autumn,
        winter
    }
    public class SessonPrinter
    {
        public void Print() 
        {
            Console.WriteLine("Enter Sesson Printer");
            String? Season1 = Console.ReadLine();

            Season season;
            if (Enum.TryParse(Season1,true,out season))
            {
                switch (season)
                {
                    case Season.spring:
                        Console.WriteLine("It's spring time! Flowers are blooming.");
                        break;
                    case Season.summer:
                        Console.WriteLine("It's summer time! Let's hit the beach.");
                        break;
                    case Season.autumn:
                        Console.WriteLine("It's autumn time! Leaves are falling.");
                        break;
                    case Season.winter:
                        Console.WriteLine("It's winter time! Time for snow and hot cocoa.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season entered.");
            }
        }
    }
}
