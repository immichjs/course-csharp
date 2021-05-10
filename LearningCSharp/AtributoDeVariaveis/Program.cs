using System;

namespace AtributoDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando");

            int idade = 32;
            int idadeMich = idade;

            Console.WriteLine(idade);
            Console.WriteLine(idadeMich);

            idade = 20;
            Console.WriteLine(idade);
            Console.WriteLine(idadeMich);

            // C# não é atribuição por referencia, e sim atribuição por cópia

            Console.ReadLine();
        }
    }
}
