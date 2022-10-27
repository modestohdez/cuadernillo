using System;

namespace TriangulosCondicionalesPractica
{
    class TriangulosCondicionales
    {
        /**
         * Elabora un programa que te solicite el valor de los 3 lados de un triangulo, en base a lo siguiente
         * Si todos los lados son iguales es un triangulo equilatero
         * Si todos los lados son desiguales es triangulo escaleno
         * Si uno de los dos lados son iguales y un lado diferente es triangulo isoceles
         */
        static void Main(string[]args)
        {
            int a, b, c;
            Console.WriteLine("Elabora un programa que te solicite el valor de los 3 lados de un triangulo, en base a lo siguiente:\n" +
                "Si todos los lados son iguales es un triangulo equilatero\n" +
                "Si todos los lados son desiguales es triangulo escaleno\n" +
                "Si uno de los dos lados son iguales y un lado diferente es triangulo isoceles");

            Console.WriteLine("Ingrese el lado A");
            a = int.Parse(Console.ReadLine() ?? String.Empty);
            Console.WriteLine("Ingrese el lado B");
            b = int.Parse(Console.ReadLine() ?? String.Empty);
            Console.WriteLine("Ingrese el lado C");
            c = int.Parse(Console.ReadLine() ?? String.Empty);

            if (a == b && a == c && b == c)
                Console.WriteLine("Es un triangulo equilatero");
            else if (a != b && a != c && b != c)
                Console.WriteLine("Es un triangulo escaleno");
            else if (a == b || a != b && a == c || a != c && b == c || b != c)
                Console.WriteLine("Es un triangulo isoceles");
            
        }
        
    }
}
