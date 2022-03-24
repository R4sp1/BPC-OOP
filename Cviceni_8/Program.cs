using System;

namespace Cviceni_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathRead = @"Cv08 - teploty.txt";
            string pathWrite = @"Cv08 - teploty(upraveno).txt";

            ArchivTeplot teploty = new ArchivTeplot();

            teploty.Load(pathRead);
            teploty.TiskTeplot();
            teploty.TiskPrumernychTeplot();
            teploty.TiskPrumernychMesicnichTeplot();

            teploty.Kalibrace(-0.1);
            teploty.Vyhledej(2013);

            teploty.Save(pathWrite);

        }
    }
}
