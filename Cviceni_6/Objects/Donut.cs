using System;

namespace Cviceni_6.Objects
{
    class Donut : Objekt3D
    {
        private double polomerKruhu;
        private double polomerValce;

        public Donut(double polomerKruhu, double polomerValce)
        {
            this.polomerKruhu = polomerKruhu;
            this.polomerValce = polomerValce;
        }

        public override double SpoctiPovrch()
        {
            return 4 * Math.Pow(Math.PI, 2) * polomerValce * polomerKruhu;
        }

        public override double SpoctiObjem()
        {
            return 2 * Math.Pow(Math.PI, 2) * Math.Pow(polomerValce, 2) * polomerKruhu;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Donut\t\t polomer kruhu: {polomerKruhu}\t polomer valce: {polomerValce}");
        }
    }
}