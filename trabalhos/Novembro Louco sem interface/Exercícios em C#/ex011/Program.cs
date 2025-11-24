using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        const int limite = 100000;
        var paresAmigaveis = EncontrarNumerosAmigaveis(limite);
        Console.WriteLine("Pares de números amigáveis entre 1 e 10000:");
        foreach (var par in paresAmigaveis)
        {
            Console.WriteLine($"[{par.Item1}, {par.Item2}]");
        }
    }

    static int SomaDivisores(int n)
    {
        int soma = 0;
        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                soma += i;
            }
        }
        return soma;
    }

    static List<(int, int)> EncontrarNumerosAmigaveis(int limite)
    {
        var paresAmigaveis = new List<(int, int)>();

        for (int a = 1; a < limite; a++)
        {
            int b = SomaDivisores(a);
            if (b > a && b < limite && SomaDivisores(b) == a)
            {
                paresAmigaveis.Add((a, b));
            }
        }

        return paresAmigaveis;
    }
}