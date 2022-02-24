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

            Console.Write("Nejdelsi slova: ");
            foreach (var word in testString.LongestWords())
            {
                if (testString.LongestWords().IndexOf(word) == testString.LongestWords().Count - 1)
                {
                    Console.WriteLine(word);
                }
                else
                {
                    Console.Write(word + ", ");
                }
            }


            Console.Write("Najkratsi slova: ");
            foreach (var word in testString.ShortestWords())
            {
                if (testString.ShortestWords().IndexOf(word) == testString.ShortestWords().Count - 1)
                {
                    Console.WriteLine(word);
                }
                else
                {
                    Console.Write(word + ", ");
                }
            }


            Console.Write("Najcastejsi slovo: ");
            foreach (var word in testString.MostWords())
            {
                Console.Write(word);
            }
            Console.WriteLine();

            Console.Write("Slova podle abecedy: ");
            foreach (var word in testString.WordsByAlphabet())
            {
                if (testString.WordsByAlphabet().IndexOf(word) == testString.WordsByAlphabet().Count - 1)
                {
                    Console.WriteLine(word + "\n");
                }
                else
                {
                    Console.Write(word + ", ");
                }
            }
        }
    }
}
