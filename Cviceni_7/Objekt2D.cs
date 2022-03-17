using System;

namespace Cviceni_7
{
    public abstract class Objekt2D : I2D, IComparable              //Abstraktni trida rozsiruje (dedi) tridu GrObjekt
    {

        public int CompareTo(object obj)
        {
            if (((Objekt2D)obj).Plocha() > this.Plocha())
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public abstract double Plocha();

    }
}