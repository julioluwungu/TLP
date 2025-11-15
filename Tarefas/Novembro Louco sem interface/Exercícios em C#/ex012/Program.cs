using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Principal().GetAwaiter().GetResult();
    }

    static async Task Principal()
    {
        List<double> valores = new List<double>();
        double outroValor;

        for (int c = 0; c < 10; c++)
        {
            while (true)
            {
                Console.Write($"Digite o {c + 1}º valor inteiro: ");
                if (double.TryParse(Console.ReadLine(), out double num))
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

        while (true)
        {
            Console.Write("Digite um outro valor: ");
            if (double.TryParse(Console.ReadLine(), out outroValor))
            {
                break;
            }
            else
            {
                Console.WriteLine("Valor inválido! Por favor, digite um número válido!");
            }
        }

        var inferiores = valores.Where(num => num < outroValor).ToList();
        Console.WriteLine($"Dentre os valores digitados anteriormente, {inferiores.Count} são inferiores à {outroValor}");
        Console.WriteLine($"Eles são: {string.Join(", ", inferiores)}");
    }
}