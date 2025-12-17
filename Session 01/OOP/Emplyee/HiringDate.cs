using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplyee
{
    internal class HiringDate
    {
        int day;
        int month;
        int year;

        public int Day
        {
            get { return day; }
            set { day = value > 0 && value < 32 ? value : 1; }
        }
        public int Month
        {
            get { return month; }
            set { month = value > 0 && value < 13 ? value : 1; }
        }
        public int Year
        {
            get { return year; }
            set { year = value > 1900 && value <= DateTime.Now.Year ? value : 1900; }
        }
        public HiringDate()
        {
           
        }
        public HiringDate(int day , int month , int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }

}
