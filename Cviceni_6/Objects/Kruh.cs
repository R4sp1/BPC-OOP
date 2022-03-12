using System;

namespace Cviceni_6.Objects
{
    class Kruh : Objekt2D
    {
        private double polomer;

        public Kruh(double polomer)
        {
            this.polomer = polomer;
        }
        public override double SpoctiPlochu()
        {
            return Math.PI * Math.Pow(polomer, 2);
        }
        public override void Kresli()
        {
            Console.WriteLine($"Kruh\t\t polomer: {polomer}");
        }
    }
}