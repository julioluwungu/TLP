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
        List<int> valores = new List<int>();
        int c = 1;

        while (true)
        {
            Console.Write($"Digite o {c}º valor: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                c++;
                if (num > 0)
                {
                    valores.Add(num);
                }
                else if (num < 0)
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Valor inválido! Por favor, digite um número válido!");
            }
        }

        double soma = valores.Sum();
        double media = soma / valores.Count;
        Console.WriteLine($"A média é de {media:F1}");
    }
}