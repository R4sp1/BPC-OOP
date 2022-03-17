using System;

namespace Cviceni_7.Objects
{
    class Kruh : Objekt2D
    {
        private double polomer;

        public Kruh(double polomer)
        {
            this.polomer = polomer;
        }
        public override double Plocha()
        {
            return Math.PI * Math.Pow(polomer, 2);
        }
        public override string ToString()
        {
            return String.Format($"Kruh ma polomer: r = {polomer}");
        }
    }
}