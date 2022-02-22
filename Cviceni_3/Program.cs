using System;




namespace Cviceni_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat1 = new double[,] {
                { 1, 3, 5},
                { 9, 7, 7},
                { 8, 2, 5}
                //{ 3, 4, 8}
            };

            double[,] mat2 = new double[,] {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 },
            };

            Matrix m1 = new Matrix(mat1);
            Matrix m2 = new Matrix(mat2);

            Console.WriteLine("Scitani:");
            Console.WriteLine(m1 + m2);

            Console.WriteLine("Odcitani:");
            Console.WriteLine(m1 - m2);

            Console.WriteLine("Nasobeni:");
            Console.WriteLine(m1 * m2);

            Console.WriteLine();

            if(m1 == m2)
            {
                Console.WriteLine("Matice jsou stejne");
            } else
            {
                Console.WriteLine("Matice nejsou stejne");
            }

            Console.WriteLine($"Determinant: {m1.Determinant()}\n");

        }
    }
}