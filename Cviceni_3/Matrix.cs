using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cviceni_3
{
    public class Matrix
    {
        public double[,] Matice;

        public Matrix(double[,] matrix)
        {
            Matice = matrix;

        }

        public static Matrix operator +(Matrix a, Matrix b) //Scitani matic
        {
            try
            {
                var mtx = new Matrix(
                    new double[a.Matice.GetLength(0), a.Matice.GetLength(1)]);
                for (int i = 0; i < a.Matice.GetLength(0); i++)
                {
                    for (int j = 0; j < a.Matice.GetLength(1); j++)
                    {
                        mtx.Matice[i, j] = a.Matice[i, j] + b.Matice[i, j];
                    }
                }
                return mtx;
            }
            catch
            {
                Console.WriteLine("Chyba: Zle velkosti matic.");

            }

            return a;
        }

        /*public static Matrix operator -(Matrix a, Matrix b) //Odcitani matic
        {
            return new Matrix();
        }
        public static Matrix operator *(Matrix a, Matrix b) //Nasobeni matic
        {
            return new Matrix();
        }
        public static bool operator ==(Matrix a, Matrix b)
        {
            return a == b;
        }
        public static bool operator !=(Matrix a, Matrix b) //Pro operator == musim definovat take !=
        {
            return !(a == b); //Uz mam definovano v opeeratoru ==
        }
        public static Matrix operator -(Matrix a) //Unarni operator -
        {
            return new Matrix();
        }
        public Matrix Determinant() //Vraci determinant matice
        {
            return new Matrix();
        }*/


        public override string ToString() //Vypis do retezce
        {
            string output = "";
            for (int i = 0; i < Matice.GetLength(0); i++)
            {
                for (int j = 0; j < Matice.GetLength(1); j++)
                {
                    if (j != Matice.GetLength(0) - 1) output += $"{Matice[i, j]},";
                }
                output += Environment.NewLine;
            }

            return output;
        }
    }
}
