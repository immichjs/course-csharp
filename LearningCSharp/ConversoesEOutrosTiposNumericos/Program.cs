using System;

namespace ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando!");

            double salario = 1200.50;

            // int suporta valores de até 32 bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // Long suporta valores de até 64 bits
            long idade = 13000000000000;
            Console.WriteLine(idade);

            // Short suporta valores de até 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.63f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
