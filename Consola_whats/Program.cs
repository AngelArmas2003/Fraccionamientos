using Library_whats;
using System;

namespace Consola_whats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Envio_Whats oen = new Envio_Whats();
            oen.EnvioWhats();

        }
    }
}
