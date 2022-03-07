using System;

namespace Cviceni_5
{
    class Osobni : Auto
    {
        private int maxOsob;
        private int prepravovaneOsoby;

        public Osobni(int pocetOsob, double stavNadrze, TypPaliva mojePalivo) : base(stavNadrze, mojePalivo)
        {
            maxOsob = 5;
            velikostNadrze = 70;

            if (pocetOsob <= maxOsob && stavNadrze <= velikostNadrze)
            {
                prepravovaneOsoby = pocetOsob;
                palivo = mojePalivo;
            }
            else if (stavNadrze > velikostNadrze)
            {
                throw new Exception($"Presahnute max mnozstvi paliva u osobniho auta! Max mnozstvi je: {velikostNadrze}!");
            }
            else
            {
                throw new Exception($"Presahnuty max pocet osob! Max pocet osob je: {maxOsob}");
            }
        }

        public override string ToString()
        {
            return String.Format($"Prepravovano osob: {prepravovaneOsoby}\t Paliva v nadrzi: {stavNadrze} l\t Typ paliva: {palivo}");
        }
    }
}