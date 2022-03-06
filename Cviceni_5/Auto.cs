using System;

namespace Cviceni_5
{
    class Auto
    {
        protected double velikostNadrze;
        protected double stavNadrze;
        protected TypPaliva palivo;
        private Autoradio radio = new Autoradio();
        public enum TypPaliva { Benzin, Nafta };

        public Auto(double stavNadrze, TypPaliva typPaliva)
        {
            this.stavNadrze = stavNadrze;
            palivo = typPaliva;
        }

        public double VelikostNadrze
        {
            get { return velikostNadrze; }
            set{stavNadrze = value;}
        }

        public TypPaliva Palivo{
            get{return palivo;}
            set{palivo = value;}
        }

        public void natankuj(TypPaliva palivo, double mnozstvi)
        {
            if ((stavNadrze + mnozstvi) <= velikostNadrze && this.palivo == palivo)
            {
                stavNadrze += mnozstvi;
            }
            else
            {
                throw new Exception("Spatne mnozstvi nebo typ paliva!");
            }
        }

        public void nastavRadio(bool zapVyp)
        {
            radio.zapnoutRadio(zapVyp);
        }

        public void nastavPredvolbu(int cislo, double kmitocet)
        {
            radio.nastavPredvolbu(cislo, kmitocet);
        }

        public void preladNaPredvolbu(int cislo)
        {
            radio.preladNaPredvolbu(cislo);
        }
        public void vypisRadio()
        {
            Console.WriteLine(radio);
        }
    }
}