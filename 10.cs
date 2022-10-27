using System;

namespace NumeroMayotMenorPractica
{
    class NumeroMayorMenor
    {
        static void Main(string[]args)
        {
            int[] n = new int[10];
            int M, m;

            for(int i = 0; i != n.Length; i++)
            {
                Console.Write($"({i+1})Ingrese un numero:");
                n[i] = int.Parse(Console.ReadLine() ?? String.Empty);
            }

            M = n[0]; 
            m = n[0];
            
            for(int j = 0; j != n.Length; j++)
            {
                if (n[j] > M)
                    M = n[j];
                if (n[j] < m)
                    m = n[j];
            }

            Console.WriteLine($"Mayor:{M}, Menor:{m}");
            

            
        }
    }
}
