using System;

namespace Cviceni_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Osobni osobak = new Osobni(4, 25, Auto.TypPaliva.Benzin);           //Vytvoreni noveho osobniho auta s dvemy osobami, 50l paliva v nadrzi a palivo benzin
            Nakladni nakladak = new Nakladni(15, 70, Auto.TypPaliva.Nafta);     //Vytvoreni noveho nakladniho auta s 15t nakladu, 75l paliva v nadrzi a palivo nafta

            //Osobni osobak = new Osobni(2, 80, Auto.TypPaliva.Benzin);
            //Nakladni nakladak = new Nakladni(30, 70, Auto.TypPaliva.Nafta);
            
            osobak.prepinacRadio(true);                                         //Zapnuti radia
            osobak.nastavPredvolbu(1, 122.5);                                   //Nastaveni predvolby cislo 1 s frekvenci 122.5
            osobak.nastavPredvolbu(2, 104.3);                                   //Nastaveni predvolby cislo 2 s frekvenci 104.3
            osobak.preladNaPredvolbu(2);                                        //Prelazeni radia na predvobu cislo 2
            osobak.vypisRadio();                                                //Vypis nastaveni radia
            osobak.preladNaPredvolbu(1);
            //osobak.preladNaPredvolbu(3);                                        //Prelazeni na predvolbu 2
            osobak.prepinacRadio(false);                                        //Vypnuti radia
            osobak.vypisRadio();                                                //Vypis nastaveni radia

            Console.WriteLine(osobak);                                          //Vypis parametru osobniho auta
            Console.WriteLine(nakladak);                                        //Vypis parametru nakladniho auta

            osobak.natankuj(Auto.TypPaliva.Nafta, 5);
            //nakladak.natankuj(Auto.TypPaliva.Nafta, 200);
            Console.WriteLine(osobak);
            //Console.WriteLine(nakladak);
        }
    }
}
