using System;

namespace ContraseñaAccessoPractica
{
    class ContraseñaAcceso
    {
        static void Main(string[]args)
        {
            string password;

            Console.WriteLine("Ingrese la contraseña");
            password = Console.ReadLine() ?? String.Empty;

            if (password == "123456789")
                Console.WriteLine("Acceso Correcto");
            else
                Console.WriteLine("Acceso Denegado");


        }
    }
}
