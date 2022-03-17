using System;

namespace Cviceni_7.Objects
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

        public override double Plocha()
        {
            double s = (stranaA + stranaB + stranaC) / 2;
            return Math.Sqrt(s * (s - stranaA) * (s - stranaB) * (s - stranaC));
        }

        public override string ToString()
        {
            return String.Format($"Trojuhelnik ma delky stran: A = {stranaA}; B = {stranaB}; C = {stranaC}");
        }

    }
}