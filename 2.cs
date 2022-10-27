using System;

namespace PromedioCalificacionesPractica
{
    class PromedioCalificaciones
    {
        static void Main(string[]args)
        {
            double calf, prom = 0.0;

            for(int i = 0; i <= 3; i++)
            {
                Console.Write($"Ingrese la calificacion {i + 1}:");
                calf = double.Parse(Console.ReadLine() ?? String.Empty);
                prom = prom + calf;
            }

            prom = prom / 3;

            if (prom == 10)
                Console.WriteLine("Excelente");
            else if (prom >= 9 && prom <= 9.9)
                Console.WriteLine("Muy Bien");
            else if (prom >= 8 && prom <= 8.9)
                Console.WriteLine("Bien");
            else if (prom >= 7 && prom <= 7.9)
                Console.WriteLine("Regular");
            else if (prom >= 6 && prom <= 6.9)
                Console.WriteLine("Suficiente");
            else
                Console.WriteLine("Insuficiente");
        }
    }
}
