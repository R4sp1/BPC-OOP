using System;



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
                var mtx = new Matrix(new double[a.Matice.GetLength(0), a.Matice.GetLength(1)]);
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
                Console.WriteLine("Chyba: Matice nejsou stejne velke");

            }

            var hal = new Matrix(new double[0, 0]);
            return hal;
        }

        public static Matrix operator -(Matrix a, Matrix b) //Odcitani matic
        {
            try
            {
                var mtx = new Matrix(new double[a.Matice.GetLength(0), a.Matice.GetLength(1)]);
                for (int i = 0; i < a.Matice.GetLength(0); i++)
                {
                    for (int j = 0; j < a.Matice.GetLength(1); j++)
                    {
                        mtx.Matice[i, j] = a.Matice[i, j] - b.Matice[i, j];
                    }
                }
                return mtx;
            }
            catch
            {
                Console.WriteLine("Chyba: Matice nejsou stejne velke");

            }
            var hal = new Matrix(new double[0, 0]);
            return hal;
        }
        public static Matrix operator *(Matrix a, Matrix b) //Nasobeni matic
        {
            try
            {
                var mtx = new Matrix(new double[a.Matice.GetLength(0), a.Matice.GetLength(1)]);
                var c = mtx.Matice;
                for (int i = 0; i < c.GetLength(0); i++)
                {
                    for (int j = 0; j < c.GetLength(1); j++)
                    {
                        c[i, j] = 0;
                        for (int k = 0; k < a.Matice.GetLength(1); k++)
                        {
                            c[i, j] = c[i, j] + a.Matice[i, k] * b.Matice[k, j];
                        }
                    }
                }
                mtx.Matice = c;
                return mtx;
            }
            catch
            {
                Console.WriteLine("Chyba: Matice nejsou stejne velke");

            }
            var hal = new Matrix(new double[0, 0]);
            return hal;
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            try
            {
                for (int i = 0; i < a.Matice.GetLength(0); i++)
                {
                    for (int j = 0; j < a.Matice.GetLength(1); j++)
                    {
                        if (a.Matice[i, j] != b.Matice[i, j]) return false;
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }
        public static bool operator !=(Matrix a, Matrix b) //Pro operator == musim definovat take !=
        {
            return !(a == b); //Uz mam definovano v operatoru ==
        }
        public static Matrix operator -(Matrix a) //Unarni operator -
        {
            var mtx = new Matrix(new double[a.Matice.GetLength(0), a.Matice.GetLength(1)]);
            for (int i = 0; i < a.Matice.GetLength(1); i++)
            {
                for (int j = 0; j < a.Matice.GetLength(0); j++)
                {
                    mtx.Matice[j, i] = a.Matice[j, i] * (-1);
                }
            }

            return mtx;
        }
        public double Determinant() //Vraci determinant matice
        {
            if (Matice.GetLength(0) == Matice.GetLength(1) && Matice.GetLength(1) == 1)
            {
                return Matice[0, 0];
            }
            else if (Matice.GetLength(0) == Matice.GetLength(1) && Matice.GetLength(1) == 2)
            {
                return Matice[0, 0] * (Matice[1, 1] - Matice[0, 1] * Matice[1, 0]);

            }
            else if (Matice.GetLength(0) == Matice.GetLength(1) && Matice.GetLength(1) == 3)
            {
                var determinant = Matice[0, 0] * (Matice[1, 1] * Matice[2, 2] - Matice[1, 2] * Matice[2, 1]) -
                                  Matice[0, 1] * (Matice[1, 0] * Matice[2, 2] - Matice[1, 2] * Matice[2, 0]) +
                                  Matice[0, 2] * (Matice[1, 0] * Matice[2, 1] - Matice[1, 1] * Matice[2, 0]);

                return determinant;
            }
            else
            {
                throw new Exception("Rozmery matice jsou vetsi nez 3x3");
            }

        }


        public override string ToString()           //Vypis do retezce
        {
            var rowCount = Matice.GetLength(0);     //Ziska pocet radku
            var ColCount = Matice.GetLength(1);     //Ziska pocet sloupcu
            string output = "";                     //Vytvoreni stringu output

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    output += $"{Matice[i, j]}\t";  //Prida do outputu radek matice
                }
                output += Environment.NewLine;
            }

            return output;
        }
    }
}
