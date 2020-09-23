using System;

namespace ImprimeNumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ==== Programa imprime Múmeros Pares ====");

            for (int i = 1; i <= 100; i++)
            {
                
                if(i % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
