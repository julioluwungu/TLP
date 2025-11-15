using System;

class Program
{
    static void Main(string[] args)
    {
        Principal().GetAwaiter().GetResult();
    }

    static async Task Principal()
    {
        int numN;
        while (true)
        {
            Console.Write("Digite um número inteiro N: ");
            if (int.TryParse(Console.ReadLine(), out numN))
            {
                break;
            }
            else
            {
                Console.WriteLine("Valor inválido! Por favor, digite um número válido!");
            }
        }

        int totalDivisoes = 0;
        var numerosPrimos = new List<int>();

        for (int i = 1; i <= numN; i++)
        {
            var resultado = EhPrimo(i);
            totalDivisoes += resultado.divisao;
            if (resultado.primo)
            {
                numerosPrimos.Add(i);
            }
        }

        Console.WriteLine($"Números primos entre 1 e {numN}: {string.Join(", ", numerosPrimos)}");
        Console.WriteLine($"Total de divisões executadas: {totalDivisoes}");
    }

    static (bool primo, int divisao) EhPrimo(int num)
    {
        if (num < 2)
        {
            return (false, 0);
        }

        int qtdDivisoes = 0;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            qtdDivisoes++;
            if (num % i == 0)
            {
                return (false, qtdDivisoes);
            }
        }
        return (true, qtdDivisoes);
    }
}