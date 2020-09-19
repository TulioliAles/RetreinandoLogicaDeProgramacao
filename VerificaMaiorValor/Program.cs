using System;

namespace VerificaMaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, maior = 0;
            Console.WriteLine("==== Programa que verifica o maior valor entre 4 números ====");
            Console.Write("Informe o 1º número: ");
            n = Convert.ToInt32(Console.ReadLine());
            maior = n;
            if (n > maior)
            {
                maior = n;
            }
            Console.Write("Informe o 2º número: ");
            n = Convert.ToInt32(Console.ReadLine());
            if(n > maior)
            {
                maior = n;
            }
            Console.Write("Informe o 3º número: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > maior)
            {
                maior = n;
            }
            Console.Write("Informe o 4º número: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > maior)
            {
                maior = n;
            }

            Console.WriteLine("O maior número é " + maior);
        }
    }
}
