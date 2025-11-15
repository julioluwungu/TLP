using System;

class Program
{
    static void Main(string[] args)
    {
        Principal().GetAwaiter().GetResult();
    }

    static async Task Principal()
    {
        int[] valores = new int[3];
        for (int c = 0; c < 3; c++)
        {
            while (true)
            {
                Console.Write($"Digite o {c + 1}º valor inteiro: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int num))
                {
                    valores[c] = num;
                    break;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Por favor, digite um número válido!");
                }
            }
        }

        double soma = valores.Sum();
        double media = soma / valores.Length;
        Console.WriteLine($"A média é de {media:F1}");
    }
}