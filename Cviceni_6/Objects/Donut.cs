using System;

namespace Cviceni_6.Objects
{
    class Donut : Objekt3D
    {
        private double polomerDonutu;
        private double polomerNaplne;

        public Donut(double polomerDonutu, double polomerNaplne)
        {
            this.polomerDonutu = polomerDonutu;
            this.polomerNaplne = polomerNaplne;
        }

        public override double SpoctiPovrch()
        {
            return 4 * Math.Pow(Math.PI, 2) * polomerNaplne * polomerDonutu;
        }

        public override double SpoctiObjem()
        {
            return 2 * Math.Pow(Math.PI, 2) * Math.Pow(polomerNaplne, 2) * polomerDonutu;
        }

        public override void Kresli()
        {
            Console.WriteLine($"Donut\t\t polomer donutu: {polomerDonutu}\t polomer naplne: {polomerNaplne}");
        }
    }
}