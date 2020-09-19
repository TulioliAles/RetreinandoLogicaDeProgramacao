using System;

namespace CalculaConsumoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal km, ltr, consumo = 0;
            Console.WriteLine("==== Programa para Cálculo de Consumo de Combustível ==== ");
            
            Console.Write("Informe o valor de Km rodado: ");
            km = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Informe o valor de Litros consumidos: ");
            ltr = Convert.ToDecimal(Console.ReadLine());

            consumo = (km / ltr) * 10;

            Console.WriteLine(Math.Round(consumo, 3) + " km/l");
        }
    }
}
