using System;

namespace Cviceni_6.Objects
{
    class Elipsa : Objekt2D                                 //Elipsa rozsiruje tridu Objekt2D
    {
        private double poloosaA;                            //Definice promenych
        private double poloosaB;

        public Elipsa(double poloosaA, double poloosaB)     //Konstruktor elipsy
        {
            this.poloosaA = poloosaA;
            this.poloosaB = poloosaB;
        }

        public override double SpoctiPlochu()               //Prepisujeme funkci SpoctiPlochu() z tridy Objekt2D
        {
            return poloosaA * poloosaB * Math.PI;
        }

        public override void Kresli()                       //Prepisujeme funkci Kresli() z tridy GrObjekt
        {
            Console.WriteLine($"Elipsa\t\t poloosa A: {poloosaA}\t poloosa B: {poloosaB}");
        }
    }
}