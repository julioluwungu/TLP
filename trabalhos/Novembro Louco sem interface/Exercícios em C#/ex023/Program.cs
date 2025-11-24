using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        int baseTriangulo;

        while (true)
        {
            Console.Write("Digite a base do triângulo (entre 5 e 15): ");
            if (int.TryParse(Console.ReadLine(), out baseTriangulo) && baseTriangulo >= 5 && baseTriangulo <= 15)
            {
                break;
            }
            else
            {
                Console.WriteLine("A base deve ser entre 5 e 15. Tente novamente.");
            }
        }

        for (int c = 1; c <= baseTriangulo; c += 2)
        {
            int espaco = (baseTriangulo - c) / 2;
            Console.WriteLine(new string(' ', espaco) + new string('#', c));
        }
    }
}