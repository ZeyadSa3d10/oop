using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    internal class Parent
    {
        private int X;
        private int Y;

        public int  x { get; set; }
        public int y { get; set; }
        public Parent(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public virtual int  prouduct()
        {
           return X*Y ;
        }
        public override string ToString() 
            {
            return $"X: {X}, Y: {Y}";
        }
    }
}
