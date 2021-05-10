using System;

namespace createDecimalVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto sendo executado: [Criando variáveis com ponto flutuante]");

            double salario;
            salario = 1200.70;
            Console.WriteLine("Salário atual: " + salario);

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);


            Console.WriteLine("Execução finalizou, continuar...");
            Console.ReadLine();
        }
    }
}
