using System;

namespace Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int idadeMich = 19;

            bool acompanhado = true;

            string addMensagem = "";

            if (acompanhado)
            {
                addMensagem = "Mich está acompanhado";
            }
            else
            {
                addMensagem = "Mich não está acompanhado";
            }

            if (idadeMich >= 18 || acompanhado)
            {
                Console.WriteLine(addMensagem);
                Console.WriteLine("Pode entrar");
            } else
            {
                Console.WriteLine(addMensagem);
                Console.WriteLine("Pode entrar");
            }

            Console.ReadLine();
        }
    }
}
