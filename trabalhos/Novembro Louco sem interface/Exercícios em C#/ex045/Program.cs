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
        int c = 1;

        while (true)
        {
            Console.Write($"Digite o {c}º número (9999 para encerrar): ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero == 9999) break;
                else
                {
                    numeros.Add(numero);
                    c++;
                }
            }
            else
            {
                Console.WriteLine("Valor inválido! Por favor, digite um número válido.");
            }
        }

        var pares = numeros.Where(num => num % 2 == 0).ToList();
        var impares = numeros.Where(num => num % 2 != 0).ToList();

        Console.WriteLine($"Quantidade de números pares: {pares.Count}");
        Console.WriteLine($"Quantidade de números ímpares: {impares.Count}");
    }
}