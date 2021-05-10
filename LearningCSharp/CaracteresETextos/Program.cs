using System;

namespace CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando");

            // char respeita a tabela ASCII
            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string title = "Isso é um texto feito em " + 2021;
            Console.WriteLine(title);

            string cursos =
@"- Vue
- React
- Angular";
            Console.WriteLine(cursos);

            Console.ReadLine();
        }
    }
}
