using System;
namespace NCalificacionesPractica
{
    class NCalificaciones
    {
        static void Main(string[]args)
        {
            int n, i;
            double calf, prom = 0.0;

            Console.Write("Ingresa el numero de calificaciones a promediar");
            n = int.Parse(Console.ReadLine() ?? String.Empty);
            for(i = 0; i <= n; i++)
            {
                Console.Write($"({i + 1})Ingrese la calificacion:");
                calf = double.Parse(Console.ReadLine() ?? String.Empty);
                prom = prom + calf;
            }
            prom = prom / n;
            Console.Write($"El promedio es de {prom}");
        }
    }
}