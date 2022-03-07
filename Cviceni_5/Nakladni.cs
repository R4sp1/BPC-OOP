using System;

namespace Cviceni_5
{
    class Nakladni : Auto
    {
        private int maxNaklad;
        private int vahaNakladu;

        public Nakladni(int velikostNakladu, double stavNadrze, TypPaliva palivo) : base(stavNadrze, palivo)
        {
            maxNaklad = 25;
            velikostNadrze = 120;

            if (velikostNakladu <= maxNaklad && stavNadrze <= velikostNadrze)
            {
                vahaNakladu = velikostNakladu;
                this.palivo = palivo;
            }
            else if (stavNadrze > velikostNadrze)
            {
                throw new Exception($"Presahnute max mnozstvi paliva u nakladniho auta! Max mnozstvi je: {velikostNadrze}!");
            }
            else
            {
                throw new Exception($"Presahnuta max vaha nakladu! Max vaha je: {maxNaklad}!");
            }
        }

        public override string ToString()
        {
            return String.Format($"Vaha nakladu: {vahaNakladu} t\t Paliva v nadrzi: {stavNadrze} l\t Typ paliva: {palivo}");
        }
    }
}