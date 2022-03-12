using System;

namespace Cviceni_6.Objects
{
    class Obdelnik : Objekt2D
    {
        private double stranaA;
        private double stranaB;
        public Obdelnik(double stranaA, double stranaB)
        {
            this.stranaA = stranaA;
            this.stranaB = stranaB;
        }
        public override double SpoctiPlochu()
        {
            return stranaA * stranaB;
        }
        public override void Kresli()
        {
            Console.WriteLine($"Obdelnik\t strana A: {stranaA}\t strana B: {stranaB}");
        }
    }
}