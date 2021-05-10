using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int idadeMich = 16;
            int quantidadePessoas = 1;

            bool acompanhado = quantidadePessoas >= 2;

            if (idadeMich >= 18 && acompanhado)
            {
                Console.WriteLine("Mich não é de maior, mas está acompanhado");
            } else
            {
                Console.WriteLine("Mich não é de maior e não está acompanhado");
            }

            Console.ReadLine();
        }
    }
}
