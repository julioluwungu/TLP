using System;

class Program
{
    static void Main(string[] args)
    {
        Principal().GetAwaiter().GetResult();
    }

    static async Task Principal()
    {
        double[] valores = new double[3];

        for (int c = 0; c < 3; c++)
        {
            while (true)
            {
                Console.Write($"Digite o {c + 1}º valor: ");
                if (double.TryParse(Console.ReadLine(), out double num))
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

        Array.Sort(valores);
        Console.WriteLine($"Maior valor: {valores[2]}");
        Console.WriteLine($"Menor valor: {valores[0]}");
        Console.WriteLine($"Valor intermédio: {valores[1]}");
    }
}