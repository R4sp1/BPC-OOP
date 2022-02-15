using System;


namespace Cviceni_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CompexNum x = new CompexNum(1.2, 0.5); // vytvoření instance třídy
            CompexNum y = new CompexNum(2.0, -1.5); // vytvoření instance třídy
            CompexNum z = x + y;
            Console.WriteLine(z);
            Console.WriteLine(z.Sdruzena());
            Console.ReadLine();
        }
    }
}
