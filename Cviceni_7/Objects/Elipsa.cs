using System;

namespace Cviceni_7.Objects
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

        public override double Plocha()               //Prepisujeme funkci SpoctiPlochu() z tridy Objekt2D
        {
            return poloosaA * poloosaB * Math.PI;
        }

        public override string ToString()                      //Prepisujeme funkci Kresli() z tridy GrObjekt
        {
            return String.Format($"Elipsa ma delky poloos: A = {poloosaA}; B = {poloosaB}");
        }
    }
}