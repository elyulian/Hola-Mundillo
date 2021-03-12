using System;

namespace consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int aux = 1, fib = 0;
            Console.WriteLine("Hola Dani ");
            Console.WriteLine("uyuyuyuyuy");
        
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(fib);

                aux += fib;
                fib = aux + fib;
            }

            int edad;
            edad = 18;
            edad++;

            Console.WriteLine("La edad es: " + edad);
        }
    }
}
