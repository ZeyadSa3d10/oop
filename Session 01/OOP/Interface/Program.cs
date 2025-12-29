namespace Interface
{
    public class Program
    {
        public static void PRINTFIFENUMBER(Iseries iseries)
        {
            if (iseries is not null)
            {
                for (int i = 0; i < 5; i++)

                {
                    Console.WriteLine(iseries.current);
                    iseries.GetNext();
                }
                    iseries.Reset();
            }
            else
            {

                return;
            }
        }
        static void Main(string[] args)
        {
            TypeA seriesObj = new TypeA();
            Iseries seriesObj2 = new TypeP();

            
           PRINTFIFENUMBER(seriesObj);
           PRINTFIFENUMBER(seriesObj2);
        }
    }
}
