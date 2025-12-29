using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binding
{
    public class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int a, int b): base(a)
        {
            B = b;
        }
        public new void MyFun01()
        {
            Console.WriteLine($"This is MyFun01 from typB class. A = {A}, B = {B}");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"This is MyFun02 from typB class. A = {A}, B = {B}");
        }

    }
}
