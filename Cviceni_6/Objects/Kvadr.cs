using System;

namespace Cviceni_6.Objects
{
    class Kvadr : Objekt3D
    {
        private double stranaA;
        private double stranaB;
        private double stranaC;

        public Kvadr(double stranaA, double stranaB, double stranaC)
        {
            this.stranaA = stranaA;
            this.stranaB = stranaB;
            this.stranaC = stranaC;
        }

        public override double SpoctiPovrch()
        {
            return 2 * (stranaA * stranaB + stranaB * stranaC + stranaA * stranaC);
        }

        public override double SpoctiObjem()
        {
            return stranaA * stranaB * stranaC;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Kvadr\t\t strana A: {stranaA}\t strana B: {stranaB}\t strana C: {stranaC}");
        }
    }
}