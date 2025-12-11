using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    internal class Child : Parent
    {
        private int Z;

        public int z { get; set; }
        public Child(int x, int y, int z) : base(x, y)
        {
            this.Z = z;
        }
        public override int prouduct()
            {
            return base.prouduct()* Z ;
        }
        public override string ToString()
        {
            return base.ToString() + $", Z: {Z}";
        }

    }
}
