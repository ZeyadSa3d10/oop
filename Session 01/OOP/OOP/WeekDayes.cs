using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public enum WeekDayes
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public class WeekDaysPrinter
    {
        public void printWeekDays()
        {
            foreach (WeekDayes day in Enum.GetValues(typeof(WeekDayes)))
            {
                Console.WriteLine(day);
            } // end foreach
        }
    }
    

}
