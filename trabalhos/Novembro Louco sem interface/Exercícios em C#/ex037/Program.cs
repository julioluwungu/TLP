using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        List<int> numeros = new List<int>();

        for (int c = 0; c < 10; c++)
        {
            while (true)
            {
                Console.Write($"Digite o {c + 1}º número inteiro: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    numeros.Add(numero);
                    break;
                }
                Console.WriteLine("Valor inválido! Por favor, digite um valor inteiro válido.");
            }
        }

        double soma = numeros.Sum();
        double media = soma / numeros.Count;
        int maior = numeros.Max();
        int menor = numeros.Min();

        Console.WriteLine($"Média: {media:F1}");
        Console.WriteLine($"Maior número: {maior}");
        Console.WriteLine($"Menor número: {menor}");
    }
}