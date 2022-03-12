using System;

namespace Cviceni_6.Objects
{
    class Koule : Objekt3D
    {
        private double polomer;

        public Koule(double polomer)
        {
            this.polomer = polomer;
        }

        public override double SpoctiPovrch()
        {
            return 4 * Math.PI * Math.Pow(polomer, 2);
        }

        public override double SpoctiObjem()
        {
            return (4 * Math.PI * Math.Pow(polomer, 3)) * 3;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Koule\t\t polomer: {polomer}");
        }
    }
}