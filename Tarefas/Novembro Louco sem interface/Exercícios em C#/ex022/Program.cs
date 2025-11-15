using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Principal().GetAwaiter().GetResult();
    }

    static async Task Principal()
    {
        List<double> numQ = new List<double>();

        for (int i = 0; i < 20; i++)
        {
            while (true)
            {
                Console.Write($"Digite o {i + 1}º valor (positivo): ");
                if (double.TryParse(Console.ReadLine(), out double num) && num > 0)
                {
                    numQ.Add(num);
                    break;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Por favor, digite um número positivo.");
                }
            }
        }

        double maiorElemento = numQ[0];
        int posicao = 0;

        for (int i = 1; i < numQ.Count; i++)
        {
            if (numQ[i] > maiorElemento)
            {
                maiorElemento = numQ[i];
                posicao = i;
            }
        }

        Console.WriteLine($"O maior elemento é {maiorElemento} e ocupa a posição {posicao + 1} no vetor.");
    }
}