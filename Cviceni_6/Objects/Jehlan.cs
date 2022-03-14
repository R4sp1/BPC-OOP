using System;

namespace Cviceni_6.Objects
{
    class Jehlan : Objekt3D                                             //Jehlan rozsiruje tridu Objekt3D
    {
        private double stranaA;                                         //Definice promenych
        private double stranaB;
        private double vyska;

        public Jehlan(double stranaA, double stranaB, double vyska)     //Konstruktor tridy
        {
            this.stranaA = stranaA;
            this.stranaB = stranaB;
            this.vyska = vyska;
        }

        public override double SpoctiPovrch()                           //Prepisujeme funkci SpoctiPovrh() z tridy Objekt3D
        {
            return stranaA * vyska * 2;
        }

        public override double SpoctiObjem()                            //Prepisujeme funkci SpoctiObjem() z tridy Objekt3D
        {
            return (Math.Pow(stranaA, 2) * vyska) / 3;                  //Math.Pow vraci danou mocninu cisla
        }

        public override void Kresli()                                   //Prepisujeme funkci Kresli() z tridy GrObjekt
        {
            Console.WriteLine($"Jehlan\t\t strana A: {stranaA}\t strana B: {stranaB}\t vyska: {vyska}");
        }
    }
}