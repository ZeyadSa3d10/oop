using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binding
{
    public class TypeA
    {
        public int A { get; set; }

        public TypeA(int a)
        {
            A = a;
        }

        public void MyFun01()
        {
            Console.WriteLine($"This is MyFun01 from typA class. A = {A}");

        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"This is MyFun02 from typA class. A = {A}");
        }
    }
}
