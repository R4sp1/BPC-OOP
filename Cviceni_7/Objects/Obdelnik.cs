using System;

namespace Cviceni_7.Objects
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
        public override double Plocha()
        {
            return stranaA * stranaB;
        }
        public override string ToString()
        {
            return String.Format($"Obdelnik ma delky stran: A = {stranaA}; B = {stranaB}");
        }
    }
}