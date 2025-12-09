using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOP
{
    internal class Program
    {
        static void Main()
        {
          WeekDaysPrinter printer = new WeekDaysPrinter();
          printer.printWeekDays();
          SessonPrinter sessonPrinter = new SessonPrinter();
          sessonPrinter.Print();
           ColorPrinter colorPrinter = new ColorPrinter();
           colorPrinter.PrintColors();
            Console.WriteLine("Enter a x1:");
            int.TryParse(Console.ReadLine(), out int x1);
            Console.WriteLine("Enter a y1:");
            int.TryParse(Console.ReadLine(), out int y1);
            Console.WriteLine("Enter a x2:");
            int.TryParse(Console.ReadLine(), out int x2);
            Console.WriteLine("Enter a y2:");
            int.TryParse(Console.ReadLine(), out int y2);

            point distans = new point(x1,y1,x2,y2 );
           
        }
    }
}
