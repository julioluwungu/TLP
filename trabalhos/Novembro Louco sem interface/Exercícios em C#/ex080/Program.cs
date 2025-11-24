using System;

class Program
{
    static void Main()
    {
        Console.Write("Escolha a figura ([1] triângulo ou [2] losango): ");
        int figura = int.Parse(Console.ReadLine());

        Console.Write("Digite o tamanho (número de linhas): ");
        int tamanho = int.Parse(Console.ReadLine());

        if (figura == 1)
        {
            DesenharTriangulo(tamanho);
        }
        else if (figura == 2)
        {
            DesenharLosango(tamanho);
        }
        else
        {
            Console.WriteLine("Opção inválida. Escolha '[1] triângulo' ou '[2] losango'.");
        }
    }

    static void DesenharTriangulo(int tamanho)
    {
        for (int c = 1; c <= tamanho; c++)
        {
            Console.WriteLine(new string(' ', tamanho - c) + new string('%', 2 * c - 1));
        }
    }

    static void DesenharLosango(int tamanho)
    {
        DesenharTriangulo(tamanho);
        for (int c = tamanho - 1; c >= 1; c--)
        {
            Console.WriteLine(new string(' ', tamanho - c) + new string('%', 2 * c - 1));
        }
    }
}