using System;

namespace Cviceni_2
{
    public class CompexNum
    {
        public double Real;
        public double Imag;
        
        public CompexNum(double real, double imag) //Konstruktor kompexniho cisla
        {
            Real = real;
            Imag = imag;
        }

        public static CompexNum operator +(CompexNum a, CompexNum b) //Scitani
        {
            return new CompexNum(a.Real + b.Real, a.Imag + b.Imag);
        }

        public static CompexNum operator -(CompexNum a, CompexNum b) //Odcitani
        {
            return new CompexNum(a.Real - b.Real, a.Imag - b.Imag);
        }

        public static CompexNum operator *(CompexNum a, CompexNum b) //Nasobeni
        {
            return new CompexNum((a.Real * b.Real) - (a.Imag * b.Imag), (a.Real * b.Imag) + (a.Imag * b.Real));
        }

        public static CompexNum operator /(CompexNum a, CompexNum b) //Deleni
        {
            return new CompexNum((a.Real * b.Real + a.Imag * b.Imag) / (b.Imag * b.Imag + b.Real * b.Real),
                                 (a.Imag * b.Real - a.Real * b.Imag) / (b.Imag * b.Imag + b.Real * b.Real));
        }

        public static bool operator ==(CompexNum a, CompexNum b)
        {
            return a.Real == b.Real && a.Imag == b.Imag;
        }

        public static bool operator !=(CompexNum a, CompexNum b) //Pro operator == musim definovat take !=
        {
            return !(a == b); //Uz mam definovano v opeeratoru ==
        }

        public static CompexNum operator -(CompexNum a) //Unarni operator -
        {
            return new CompexNum(-a.Real, -a.Imag);
        }


        public CompexNum Sdruzena()
        {
            return new CompexNum(Real, -Imag);
        }

        public override string ToString() //Vypis do retezce
        {
            if (Imag < 0)
            {
                return string.Format("{0}-{1}j", Real, -Imag);
            }
            else
            {
                return string.Format("{0}+{1}j", Real, Imag);
            }
        }
    }
}
