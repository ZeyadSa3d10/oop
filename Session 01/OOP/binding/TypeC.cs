using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binding
{
    internal class TypeC: TypeB
    {
        public int C { get; set; }
        public TypeC(int a, int b, int c) : base(a, b)
        {
            C = c;
        }
        public new void MyFun01()
        {
            Console.WriteLine($"This is MyFun01 from typC class. A = {A}, B = {B}, C = {C}");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"This is MyFun02 from typC class. A = {A}, B = {B}, C = {C}");
        }
    }
}
