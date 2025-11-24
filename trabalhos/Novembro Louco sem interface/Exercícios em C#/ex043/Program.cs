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
        int numero;
        int c = 1;

        while (true)
        {
            while (true)
            {
                Console.Write($"Digite o {c}º número (9999 para encerrar): ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    break;
                }
                Console.WriteLine("Valor inválido! Por favor, digite um valor válido.");
            }

            if (numero != 9999)
            {
                numeros.Add(numero);
            }
            else
            {
                break;
            }

            c++;
        }

        int maior = numeros.Max();
        Console.WriteLine($"O maior valor digitado é: {maior}");
    }
}