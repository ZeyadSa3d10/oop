namespace binding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeA typeAobj = new TypeB(10, 20);

            typeAobj.A=100;

            //typeAobj.B = 300; // This line will cause a compile-time error because 'B' is not a member of 'TypeA'
            typeAobj.MyFun01(); // Calls TypeA's MyFun01
            typeAobj.MyFun02();

            TypeB typeBobj = new TypeC(1, 2, 3);
            typeBobj.A = 500;
            typeBobj.B = 600;
            //typeBobj.C = 700; // This line will cause a compile-time error because 'C' is not a member of 'TypeB'
            typeBobj.MyFun01(); // Calls TypeB's MyFun01
            typeBobj.MyFun02();


        }
    }
}
