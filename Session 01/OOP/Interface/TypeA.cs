using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class TypeA : Iseries
    {
        public int current { get ; set ; }

        public void GetNext()
        {
             current += 2 ;
        }
    }
}
