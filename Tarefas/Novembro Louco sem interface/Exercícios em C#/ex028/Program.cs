using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        List<int> valores = new List<int>();

        for (int c = 0; c < 50; c++)
        {
            while (true)
            {
                Console.Write($"Digite o {c + 1}º valor: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    valores.Add(num);
                    break;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Por favor, digite um número válido!");
                }
            }
        }

        var positivos = valores.Where(num => num > 0).ToList();
        var negativos = valores.Where(num => num < 0).ToList();
        int soma = positivos.Sum();

        Console.WriteLine($"A soma dos valores positivos digitados é de: {soma}");
        Console.WriteLine($"A quantidade dos valores negativos digitados é de: {negativos.Count}");
    }
}