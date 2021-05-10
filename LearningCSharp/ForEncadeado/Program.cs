using System;

namespace ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13 - For Encadeado");

            // Forma que eu fiz, apenas KKKKKK
            for (int countRow = 0; countRow < 10; countRow++)
            {
                for (int countCol = 0; countCol < countRow; countCol++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int countRow = 0; countRow < 10; countRow++)
            {
                // Forma besta de fazer
                for (int countCol = 0; countCol < 10; countCol++)
                {
                    Console.Write("*");
                    if (countCol >= countRow) break;
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
