using System;
using System.Linq;
using Cviceni_7.Objects;

namespace Cviceni_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] poleInt = new int[] { 1, 2, 8, 10, 122, 3, 72, 81, 2022, 123, 96, 126, 996, 302022, 7 };
            string[] poleString = new string[] { "May", "the", "force", "be", "with", "you" };
            Kruh[] poleKruh = new Kruh[] { new Kruh(5.2), new Kruh(2), new Kruh(15), new Kruh(7.3), new Kruh(0.2) };
            Obdelnik[] poleObdelnik = new Obdelnik[] { new Obdelnik(2.3, 5), new Obdelnik(5.9, 2), new Obdelnik(3, 8), new Obdelnik(12, 2.1) };
            Objekt2D[] poleObjekt2D = new Objekt2D[] { new Kruh(2.7), new Elipsa(4.7, 3), new Obdelnik(7, 1), new Trojuhelnik(3, 3, 3), new Ctverec(5) };

            Console.WriteLine($"\nNejvetsi Int: {Extremy.Nejvetsi(poleInt)}");
            Console.WriteLine($"Nejmensi Int: {Extremy.Nejmensi(poleInt)}");

            Console.WriteLine($"\nNejdelsi String: {Extremy.Nejvetsi(poleString)}");
            Console.WriteLine($"Nejkratsi String: {Extremy.Nejmensi(poleString)}");

            Console.WriteLine($"\nNejvetsi {Extremy.Nejvetsi(poleKruh)}");
            Console.WriteLine($"Nejmensi {Extremy.Nejmensi(poleKruh)}");

            Console.WriteLine($"\nNejvetsi {Extremy.Nejvetsi(poleObdelnik)}");
            Console.WriteLine($"Nejmensi {Extremy.Nejmensi(poleObdelnik)}");

            Console.WriteLine($"\nNejvetsi 2D objekt: {Extremy.Nejvetsi(poleObjekt2D)}");
            Console.WriteLine($"Nejmensi 2D objekt: {Extremy.Nejmensi(poleObjekt2D)}");

            int[] poleFilterInt = new int[] { 1, 5, 3, 7, 9 };
            var filtered = poleFilterInt.Where(v => v > 4 && v < 8);
            Console.Write("\nLINQ filtr vysledek: ");
            int last = filtered.Last();
            foreach (int item in filtered)
            {
                if (item.Equals(last))
                {
                    Console.WriteLine($"{item}\n");
                }
                else
                {
                Console.Write($"{item}, ");
                }
            }
        }
    }
}
