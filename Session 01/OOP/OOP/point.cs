using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal struct point
    {
        
       public int x;
       public int y;
       public int x2;
       public int y2;

        public point (int X,int Y , int X2 , int Y2)
          {
                x = X;
                y = Y;
                x2 = X2;
                y2 = Y2;
            Console.WriteLine($"destans = {x+x2} + {y+y2} = {(x+x2)+(y+y2)}" );
        }



    }
}
