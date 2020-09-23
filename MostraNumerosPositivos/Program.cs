using System;

namespace MostraNumerosPositivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, n6 = 0;
            int[] positivos = new int[6];

            Console.WriteLine("==== Programa que mostra a quantidade de Números Positivos ====");

            Console.Write("Digite o 1º número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 2º número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 3º número: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 4º número: ");
            n4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 5º número: ");
            n5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o 6º número: ");
            n6 = Convert.ToInt32(Console.ReadLine());

            if(n1 >= 0)
            {
                positivos = n1[0];
            }if(n2 >= 0)

        }
    }
}
