using System;
using Cviceni_6.Objects;

namespace Cviceni_6
{
    class Program
    {
        static void Main(string[] args)
        {
            GrObjekt[] pole = new GrObjekt[] {                      //Naplneny pole objektu objekty
                    new Kruh(5.2),
                    new Elipsa(8, 3),
                    new Jehlan(4, 8.8, 2),
                    new Koule(5),
                    new Kvadr(4.1, 4.2, 4.3),
                    new Obdelnik(3, 8),
                    new Trojuhelnik(6, 2, 6.5),
                    new Valec(7, 10),
                    new TriCylinder(3.5),
                    new Donut(2.5, 0.5)
            };

            double plocha = 0;                                      //Inicializace promenych
            double povrch = 0;
            double objem = 0;

            foreach (var item in pole)                              //Prochazeni vsech polozek v poli
            {
                item.Kresli();                                      //Volani jednotlivych objektu v poli
                if (item is Objekt2D)
                {
                    plocha += ((Objekt2D)item).SpoctiPlochu();      //Pokud je objekt 2D vypočte se plocha
                }
                else
                {
                    povrch += ((Objekt3D)item).SpoctiPovrch();      //Pokud je objekt 3D vypočte se povrch a objem
                    objem += ((Objekt3D)item).SpoctiObjem();

                    double povrchObjektu = Math.Round(((Objekt3D)item).SpoctiPovrch(), 2);
                    double objemObjektu = Math.Round(((Objekt3D)item).SpoctiObjem(), 2);


                    Console.WriteLine($"Povrch {(Objekt3D)item} je: {povrchObjektu}, objem je: {objemObjektu}");
                }
            }

            
            plocha = Math.Round(plocha, 3);                         //Zaokrouhlovani na 3 desetinna mista
            povrch = Math.Round(povrch, 3);
            objem = Math.Round(objem, 3);
            

            Console.WriteLine($"\nCelkova plocha je:\t{plocha}\ncelkovy povrch je:\t{povrch}\ncelkovy objem je:\t{objem}");

        }
    }
}
