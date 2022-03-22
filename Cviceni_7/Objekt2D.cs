using System;

namespace Cviceni_7
{
    public abstract class Objekt2D : I2D, IComparable              //Abstraktni trida rozsiruje (dedi) interface I2D a IComparable
    {

        public int CompareTo(object obj)
        {
            if (((Objekt2D)obj).Plocha() > this.Plocha())
            {
                return -1;
            }
            else if (((Objekt2D)obj).Plocha() < this.Plocha())
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public abstract double Plocha();

    }
}