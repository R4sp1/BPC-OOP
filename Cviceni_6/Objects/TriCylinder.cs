// https://www.geogebra.org/m/dpekbqbc


using System;

namespace Cviceni_6.Objects
{
    class TriCylinder : Objekt3D
    {
        private double polomer;

        public TriCylinder(double polomer)
        {
            this.polomer = polomer;
        }

        public override double SpoctiPovrch()
        {
            return 3 * (16 - 8 * Math.Sqrt(2)) * Math.Pow(polomer, 2);
        }

        public override double SpoctiObjem()
        {
            return (16 - 8 * Math.Sqrt(2)) * Math.Pow(polomer, 3);
        }

        public override void Kresli()
        {
            Console.WriteLine($"TriCylinder\t polomer: {polomer}");
        }
    }
}