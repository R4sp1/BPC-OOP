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
            set { stavNadrze = value; }
        }

        public TypPaliva Palivo
        {
            get { return palivo; }
            set { palivo = value; }
        }

        public void natankuj(TypPaliva palivo, double mnozstvi)
        {
            if ((stavNadrze + mnozstvi) <= velikostNadrze && this.palivo == palivo)
            {
                stavNadrze += mnozstvi;
            }
            else if(this.palivo != palivo)
            {
                throw new Exception("Spatny typ paliva!");
            }
            else
            {
                throw new Exception("Spatne mnozstvi paliva!");
            }
        }

        public void prepinacRadio(bool radioState)
        {
            radio.prepinacRadio(radioState);
        }

        public void nastavPredvolbu(int num, double freq)
        {
            radio.nastavPredvolbu(num, freq);
        }

        public void preladNaPredvolbu(int num)
        {
            radio.preladNaPredvolbu(num);
        }
        public void vypisRadio()
        {
            Console.WriteLine(radio);
        }
    }
}