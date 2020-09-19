using System;

namespace VerificaParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
                  
            Console.WriteLine("==== Programa Verifica se um número é Par ou Impar ====");
            Console.Write("Informe um número: ");
            
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("O número " + numero + " é PAR!");
            }
            else
            {
                Console.WriteLine("O número " + numero + " é IMPAR!");
            }
        }
    }
}
