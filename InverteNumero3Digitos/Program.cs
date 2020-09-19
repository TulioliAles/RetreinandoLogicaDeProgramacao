using System;

namespace InverteNumero3Digitos
{
    class Program
    {
        static void Main(string[] args)
        {
            int ni, c, d, u = 0;
            Console.WriteLine("==== Programa Inverte Número 3 Dígitos ====");
            Console.Write("Informe um número com 3 dígitos: ");
            ni = Convert.ToInt32(Console.ReadLine());
            c = ni / 100;
            d = (ni % 100) / 10;
            u = ni % 10;
            Console.WriteLine("O número invertido é " + u + d + c);
        }

    }
}
