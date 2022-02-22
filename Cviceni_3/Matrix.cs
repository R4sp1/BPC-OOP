using System;



namespace Cviceni_3
{
    public class Matrix
    {
        public double[,] Matice;


        public Matrix(double[,] matrix)                                                                     //Konstruktor
        {
            Matice = matrix;

        }

        public static Matrix operator +(Matrix a, Matrix b)                                                 //Scitani matic
        {
            try                                                                                             //try a catch pro osetreni vyjimek
            {
                var mat = new Matrix(new double[a.Matice.GetLength(0), a.Matice.GetLength(1)]);             //Vytvoreni nove matice
                for (int i = 0; i < a.Matice.GetLength(0); i++)                                             //Prochazeni jednotlivych radku
                {
                    for (int j = 0; j < a.Matice.GetLength(1); j++)                                         //a sloupcu
                    {
                        mat.Matice[i, j] = a.Matice[i, j] + b.Matice[i, j];                                 //Scitani prvku v matici
                    }
                }
                return mat;                                                                                 //Vraceni nove matice, ktera obsahuje soucet dvou vstupnich matic
            }
            catch
            {
                Console.WriteLine("Chyba: Matice nejsou stejne velke");                                     //Pokud matice nejsou stejne velke vratime chybu

            }

            var hal = new Matrix(new double[0, 0]);                                                         //Vytvoreni prazdne matice protoze musime neco vratit i kdyz nastane chyba
            return hal;
        }

        public static Matrix operator -(Matrix a, Matrix b)                                                 //Odcitani matic
        {
            try
            {
                var mat = new Matrix(new double[a.Matice.GetLength(0), a.Matice.GetLength(1)]);             
                for (int i = 0; i < a.Matice.GetLength(0); i++)
                {
                    for (int j = 0; j < a.Matice.GetLength(1); j++)
                    {
                        mat.Matice[i, j] = a.Matice[i, j] - b.Matice[i, j];                                 //Funguje stejne jako scitani jen v tomto pripade odcitame
                    }
                }
                return mat;
            }
            catch
            {
                Console.WriteLine("Chyba: Matice nejsou stejne velke");

            }
            var hal = new Matrix(new double[0, 0]);
            return hal;
        }
        public static Matrix operator *(Matrix a, Matrix b)                                                 //Nasobeni matic
        {
            try
            {
                var mat = new Matrix(new double[a.Matice.GetLength(0), a.Matice.GetLength(1)]);
                var c = mat.Matice;
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
                mat.Matice = c;
                return mat;
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
                        if (a.Matice[i, j] != b.Matice[i, j]) return false;                                 //Prochazeni matici a porovnavani obsahu
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool operator !=(Matrix a, Matrix b)                                                  //Pro operator == musim definovat take !=
        {
            return !(a == b);                                                                               //Uz mam definovano v operatoru ==, vracim jen opacnou hodnotu
        }

        public static Matrix operator -(Matrix a)                                                           //Unarni operator -
        {
            var mat = new Matrix(new double[a.Matice.GetLength(0), a.Matice.GetLength(1)]);
            for (int i = 0; i < a.Matice.GetLength(1); i++)
            {
                for (int j = 0; j < a.Matice.GetLength(0); j++)
                {
                    mat.Matice[j, i] = a.Matice[j, i] * (-1);                                               //Prochazim matici a kazdy prvek nasobim -1
                }
            }

            return mat;
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
                throw new Exception("Rozmery matice jsou vetsi nez 3x3");                                   //Vyhozeni nove vyjimky pokud je matice vetsi nez 3x3
            }

        }


        public override string ToString()                                                                   //Vypis do retezce
        {
            var rowCount = Matice.GetLength(0);                                                             //Ziska pocet radku
            var ColCount = Matice.GetLength(1);                                                             //Ziska pocet sloupcu
            string output = "";                                                                             //Vytvoreni stringu output

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < ColCount; j++)
                {
                    output += $"{Matice[i, j]}\t";                                                          //Prida do outputu radek matice
                }
                output += Environment.NewLine;
            }

            return output;
        }
    }
}
