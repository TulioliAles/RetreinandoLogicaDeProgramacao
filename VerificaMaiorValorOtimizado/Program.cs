using System;

namespace VerificaMaiorValorOtimizado
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, maior = 0, indice = 0;

            Console.WriteLine("==== Programa que informa o Maior Valor informado ====");

            Console.Write("Informe o 1º valor: ");
            numero = Convert.ToInt32(Console.ReadLine());
            maior = numero;
            indice = 1;
            while(indice <= 9)
            {
                indice++;
                Console.Write("Informe o " + indice + " valor: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if(numero > maior)
                {
                    maior = numero;
                }
            }

            Console.WriteLine("O Maior Valor digitado foi " + maior);
        }
    }
}
