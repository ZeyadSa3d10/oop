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
        }
    }
}
