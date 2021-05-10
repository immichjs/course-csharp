using System;

namespace createVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando variáveis");

            int idade;
            idade = 19;

            Console.WriteLine("Minha idade é: " + idade);

            idade = 19 + 1;
            Console.WriteLine("Nova idade: " + idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("Sua nova idade é: " + idade);


            Console.WriteLine("Execução finalizada...");
            Console.ReadLine();
        }
    }
}
