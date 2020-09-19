using System;

namespace CalculaVolumeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, volume = 0;
            Console.WriteLine("==== Programa que Calcula o Volume de uma Esfera ====");
            Console.Write("Infrome o Raio da Esfera: ");
            raio = Convert.ToDouble(Console.ReadLine());
            volume = (4 / 3.0) * 3.14159 * Math.Pow(raio, 3);
            Console.WriteLine("VOLUME = " + Math.Round(volume, 3));
        }
    }
}
