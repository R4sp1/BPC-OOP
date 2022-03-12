using System;

namespace Cviceni_6.Objects
{
    class Elipsa : Objekt2D
    {
        private double poloosaA;
        private double poloosaB;

        public Elipsa(double poloosaA, double poloosaB)
        {
            this.poloosaA = poloosaA;
            this.poloosaB = poloosaB;
        }

        public override double SpoctiPlochu()
        {
            return poloosaA * poloosaB * Math.PI;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Elipsa\t\t poloosa A: {poloosaA}\t poloosa B: {poloosaB}");
        }
    }
}