using System;

namespace FactorialPractica
{
    class Factorial
    {
        static void Main(string[]args)
        {
            int n, i, fact = 1;

            Console.Write("Ingrese un numero:");
            n = int.Parse(Console.ReadLine() ?? String.Empty);

            for (i = 1; i <= n; i++)
                fact = fact * i;

            Console.WriteLine($"El factorial de {n} es de {fact}");

        }
    }
}