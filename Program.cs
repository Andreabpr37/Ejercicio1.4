using System;

namespace T03_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 1, B = 2, C = 3, D = 4, AUX;
            Console.WriteLine("Valores iniciales");
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
            Console.WriteLine("C = " + C);
            Console.WriteLine("D = " + D);
            AUX = B;
            B = C;
            C = A;
            A = D;
            D = AUX;
            Console.WriteLine("Valores finales");
            Console.WriteLine("B toma el valor de C -> B = " + B);
            Console.WriteLine("C toma el valor de A -> C = " + C);
            Console.WriteLine("A toma el valor de D -> A = " + A);
            Console.WriteLine("D toma el valor de B -> D = " + D);
        }
    }
}
