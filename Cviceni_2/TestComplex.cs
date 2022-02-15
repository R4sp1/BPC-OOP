using System;

namespace Cviceni_2
{
    public class TestComplex
    {
        const double Epsilon = 1E-6;

        public static void Test(CompexNum skutecna, CompexNum ocekavana, string nazev)
        {
            if(skutecna == ocekavana)
            {
                Console.WriteLine($"{nazev}: OK");
            }
            else
            {
                Console.WriteLine($"{nazev}: Chyba: Ocekavana hodnota: {ocekavana}, Skutecna hodnota: {skutecna}");
            }
        }
    }
}
