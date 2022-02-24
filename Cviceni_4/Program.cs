using System;

namespace Cviceni_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
                                    + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                                    + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                                    + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                                    + "posledni veta!";

            StringStatistic testString = new StringStatistic(testovaciText);

            Console.WriteLine($"\n{testovaciText}\n");
            
            Console.WriteLine($"Pocet slov je: {testString.WordCount()}");
            Console.WriteLine($"Pocet radku je: {testString.LineCount()}");
            Console.WriteLine($"Pocet vet je: {testString.SentenceCount()}");

            Console.Write("Nejdelsi slova: " );
            foreach (var word in testString.LongestWords()) {
                Console.Write(word + " ");
            }
            Console.WriteLine();

            Console.Write("Najkratsi slova: ");
            foreach (var word in testString.ShortestWords())
            {
                Console.Write(word + " ");
            }
            Console.WriteLine("");

            Console.WriteLine();
        }
    }
}
