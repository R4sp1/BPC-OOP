using System;

namespace Cviceni_6.Objects
{
    class Jehlan : Objekt3D
    {
        private double stranaA;
        private double stranaB;
        private double vyska;

        public Jehlan(double stranaA, double stranaB, double vyska)
        {
            this.stranaA = stranaA;
            this.stranaB = stranaB;
            this.vyska = vyska;
        }

        public override double SpoctiPovrch()
        {
            return stranaA * vyska * 2;
        }

        public override double SpoctiObjem()
        {
            return (Math.Pow(stranaA, 2) * vyska) / 3;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Jehlan\t\t strana A: {stranaA}\t strana B: {stranaB}\t vyska: {vyska}");
        }
    }
}