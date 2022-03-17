using System;

namespace Cviceni_7.Objects
{
    class Ctverec : Objekt2D
    {
        private double strana;
        public Ctverec(double strana)
        {
            this.strana = strana;
        }
        public override double Plocha()
        {
            return Math.Pow(strana, 2);
        }
        public override string ToString()
        {
            return String.Format($"Ctverec ma delku strany A = {strana}");
        }
    }
}