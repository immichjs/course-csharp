using System;

namespace CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 12 - Calcula Investimento de Longo Prazo");

            double valorInvestido = 1000;
            double rendimento = 1.0036;

            for (int countYear = 0; countYear < 5; countYear++)
            {
                for (int countMonth = 1; countMonth <= 12; countMonth++)
                {
                    valorInvestido *= rendimento;
                }
                rendimento += 0.0010;
            }

            Console.WriteLine("Ao término do prazo de investimento, você terá R$ " + valorInvestido);

            Console.ReadLine();
        }
    }
}
