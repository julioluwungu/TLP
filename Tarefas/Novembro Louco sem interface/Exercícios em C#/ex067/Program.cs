using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> multiplos5 = new List<int>();
        int fim = 10000;

        for (int num = 1; num <= fim; num++)
        {
            if (num % 5 == 0)
            {
                multiplos5.Add(num);
            }
        }

        double percentual5 = (multiplos5.Count * 100.0) / fim;
        Console.WriteLine($"No intervalo de 1 à 10.000 foram encontrados {multiplos5.Count} múltiplos de 5.");
        Console.WriteLine($"O percentual de 5 é de {percentual5:F1}%");
    }
}