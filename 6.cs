using System;

namespace AproximacionPiPractica
{
    class AproximacionPi
    {
        static void Main(string[]args)
        {
            double pi = 3, factor = 2;
            int n;

            Console.Write("Ingrese la cantidad de terminos:");
            n = int.Parse(Console.ReadLine() ?? String.Empty);

            for(int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                    pi = pi - (4 / (factor * (factor + 1) * (factor + 2)));
                else
                    pi = pi + (4 / (factor * (factor + 1) * (factor + 2)));

                factor = factor + 2;
            }
            Console.WriteLine($"Aproximacion de Pi es de {pi}");
        }

    }
}