using System;


namespace Cviceni_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CompexNum x = new CompexNum(1.1, 0.5); // vytvoření instance třídy
            CompexNum y = new CompexNum(2.0, -1.5); // vytvoření instance třídy
            TestComplex.Test(x + y, new CompexNum(3.2, -1), "Test scitani");
            TestComplex.Test(x - y, new CompexNum(-0.8, +2), "Test odcitani");
            TestComplex.Test(x * y, new CompexNum(3.15, -0.8), "Test nasobeni");
            TestComplex.Test(x / y, new CompexNum(0.264, 0.448), "Test deleni");
            TestComplex.Test(-x, new CompexNum(-1.2, -0.5), "Test unarniho operatoru -");
            Console.WriteLine($"Cisla se rovnaji: {x == y}");
            Console.WriteLine($"Cisla se nerovnaji: {x != y}");
            Console.WriteLine($"Sdruzene cislo k cislu {x} je {x.Sdruzena()}");
            Console.WriteLine($"Modul cisla {x} je {x.Modul()}");
            Console.WriteLine($"Argument cisla {x} je {x.Argument()}");
            Console.ReadLine();
        }
    }
}
