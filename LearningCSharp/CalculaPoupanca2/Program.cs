using System;

namespace CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 11 - Calcula Poupança 2");

            double valorInvestido = 1000;

            for (int count = 0; count < 12; count++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Mes " + (count + 1) + ": " + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
