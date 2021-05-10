using System;

namespace CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 10 - Calcula poupança");

            double valorInvestido = 1000;

            Console.WriteLine();

            

            int count = 0;
            while (count < 12)
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine("Mes " + (count + 1) + ": R$ " + valorInvestido);
                count++;
            }



            Console.ReadLine();
        }
    }
}
