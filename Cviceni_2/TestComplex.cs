using System;

namespace Cviceni_2
{
    public class TestComplex
    {
        const double Epsilon = 1E-6;

        public static void Test(CompexNum skutecna, CompexNum ocekavana, string nazev)
        {
            if(Math.Abs(skutecna.Real - ocekavana.Real) < Epsilon && Math.Abs(skutecna.Imag - ocekavana.Imag) < Epsilon)
            {
                Console.WriteLine($"{nazev}: OK");
            }
            else
            {
                Console.WriteLine($"Chyba {nazev}: Ocekavana hodnota: {ocekavana}, Skutecna hodnota: {skutecna}");
            }
        }
    }
}
