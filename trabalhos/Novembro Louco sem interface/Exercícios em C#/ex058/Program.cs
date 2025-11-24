using System;
using System.Collections.Generic;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        int numN;

        while (true)
        {
            Console.Write("Informe um número inteiro N (N >= 2): ");
            if (int.TryParse(Console.ReadLine(), out numN) && numN >= 2)
            {
                break;
            }
            Console.WriteLine("Valor inválido! Por favor, digite um número inteiro maior ou igual a 2.");
        }

        List<int> fibonacci = new List<int> { 0, 1 };

        for (int c = 2; c < numN; c++)
        {
            int proximoTermo = fibonacci[c - 1] + fibonacci[c - 2];
            fibonacci.Add(proximoTermo);
        }

        Console.WriteLine($"Os {numN} primeiros termos da sequência de Fibonacci são: {string.Join(", ", fibonacci)}");
    }
}