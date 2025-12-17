using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Hairingdate
{
        private int day;
        private int month;
        private int year;

        public Hairingdate()
        {
            
        }
        public Hairingdate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int Day 
        { 
            get { return day; } 
            set { day = value > 0 && value < 31 ? value :1 ; }
        }
        public int Month 
        { 
            get { return month; } 
            set { month = value > 0 && value < 13 ? value :1 ; }
        }
        public int Year 
        { 
            get { return year; } 
            set { year = value > 1900 && value < DateTime.Now.Year ? value :1900 ; }
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
