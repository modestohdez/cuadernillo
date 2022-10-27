using System;

namespace RestauranteFamiliarPractica
{
    class RestauranteFamiliar
    {
        static void Main(string[]args)
        {
            double tp, restp;
            Console.Write("Ingrese el total a pagar");
            tp = double.Parse(Console.ReadLine() ?? String.Empty);

            if (tp >= 850 && tp <= 1000)
                restp = tp - (tp * .10);
            else if (tp >= 1001 && tp <= 1500)
                restp = tp - (tp * .15);
            else if (tp >= 1500)
                restp = tp - (tp * .20);
            else
                restp = tp;
            Console.WriteLine($"El total a pagar es de {restp}");
        }
    }
}