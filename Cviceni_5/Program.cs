using System;

namespace Cviceni_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Osobni osobak = new Osobni(2, 50, Auto.TypPaliva.Benzin);
            Nakladni nakladak = new Nakladni(15, 70, Auto.TypPaliva.Nafta);

            osobak.nastavRadio(true);
            osobak.nastavPredvolbu(3, 142);
            osobak.nastavPredvolbu(4, 55.8);
            osobak.preladNaPredvolbu(3);
            osobak.vypisRadio();
            osobak.preladNaPredvolbu(4);
            osobak.vypisRadio();

            Console.WriteLine(osobak);
            Console.WriteLine(nakladak);
        }
    }
}
