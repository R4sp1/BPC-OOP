using System;

namespace Cviceni_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathRead = @"C:\Users\jirka\Documents\GitHub\OOP\Cviceni_8\Cv08 - teploty.txt";
            string pathWrite = @"C:\Users\jirka\Documents\GitHub\OOP\Cviceni_8\Cv08 - teploty(upraveno).txt";

            ArchivTeplot teploty = new ArchivTeplot();

            teploty.Load(pathRead);                                 //Nacteni souboru
            teploty.TiskTeplot();                                   //Zobrazeni tplot ze souboru
            teploty.TiskPrumernychTeplot();                         //Zobrazeni prumernych teplot
            teploty.TiskPrumernychMesicnichTeplot();                //Zobrazeni prumernych mesicnich teplot

            teploty.Kalibrace(0.1);                                //Kalibrace zadanou hodnotou
            teploty.Vyhledej(2013);                                 //Vyhledání a vypsani zadaneho roku

            teploty.Save(pathWrite);                                //Ulozeni do noveho souboru
            //Console.ReadLine();
        }
    }
}
