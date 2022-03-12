using System;

namespace Cviceni_6.Objects
{
    class Trojuhelnik : Objekt2D
    {
        private double stranaA;
        private double stranaB;
        private double stranaC;

        public Trojuhelnik(double stranaA, double stranaB, double stranaC)
        {
            this.stranaA = stranaA;
            this.stranaB = stranaB;
            this.stranaC = stranaC;
        }

        public override double SpoctiPlochu()
        {
            double s = (stranaA + stranaB + stranaC) / 2;
            return Math.Sqrt(s * (s - stranaA) * (s - stranaB) * (s - stranaC));
        }

        public override void Kresli()
        {
            Console.WriteLine($"Trojuhelnik\t strana A: {stranaA}\t strana B: {stranaB}\t strana C: {stranaC}");
        }

    }
}