using System;




namespace Cviceni_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var mat1 = new double[,] {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 }
                //{ 3, 4, 8}
            };

            var mat2 = new double[,] {
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

            if (m1 == m2)
            {
                Console.WriteLine("Matice jsou stejne");
            }
            else
            {
                Console.WriteLine("Matice nejsou stejne");
            }

            Console.WriteLine($"Determinant: {m1.Determinant()}\n");

        }
    }
}