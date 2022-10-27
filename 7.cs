using System;

namespace PropinaRestaurantePractica
{
    class PropinaRestaurante
    {
        static void Main(string[]args)
        {
            double cost = 0.0, propina = 0.0;
            int experence = 0;

            const int maxS = 20, mediaS = 15, minS = 10;

            Console.Write("Ingresa el gasto total del comensal:");
            cost = double.Parse(Console.ReadLine() ?? String.Empty);

            Console.Write("Del 1 al 3 (siendo 3 el mejor), cual fue su nivel de satisfaccion durante la estadia en el restaurante:");
            experence = int.Parse(Console.ReadLine() ?? String.Empty);

            switch(experence)
            {
                case 1:
                    propina = cost * ((double)minS / 100);
                    break;
                case 2:
                    propina = cost * ((double)mediaS / 100);
                    break;
                case 3:
                    propina = cost * ((double)maxS / 100);
                    break;
                default:
                    Console.WriteLine("Nivel de satisfaccion no existente");
                    break;
            }

            Console.WriteLine($"La propina es de {propina}");
        }
    }
}