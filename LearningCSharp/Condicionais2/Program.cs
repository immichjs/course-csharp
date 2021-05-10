using System;

namespace Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int idadeMich = 19;
            int quantidadePessoas = 0;

            bool acompanhado = quantidadePessoas >= 2;

            if (idadeMich >= 18 || acompanhado == true)
            {
                Console.WriteLine("Mich pode entrar");
            }
            else
            {
                Console.WriteLine("Mich não é de maior e não está acompanhado");
            }

            Console.ReadLine();
        }
    }
}
