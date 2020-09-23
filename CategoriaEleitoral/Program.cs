using System;

namespace CategoriaEleitoral
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;

            Console.WriteLine("==== Programa que mostra a Categoria de um Eleitor ====");

            Console.WriteLine("Digite a idade do eleitor: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 16)
            {
                Console.WriteLine("Categoria: Não Eleitor");
            }
            else if (idade == 16 || idade == 17 || idade >= 65)
            {
                Console.WriteLine("Categoria: Eleitor de voto Facultativo");
            }
            else if (idade >= 18 && idade < 65)
            {
                Console.WriteLine("Categoria: Eleitor de voto Obrigatório");
            }
        }
    }
}
