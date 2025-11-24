using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        double numero;

        while (true)
        {
            Console.Write("Digite um número: ");
            if (double.TryParse(Console.ReadLine(), out numero))
            {
                break;
            }
            Console.WriteLine("Valor inválido! Por favor, digite um número válido.");
        }

        int contagem = 0;
        double resultado = numero;

        while (resultado >= 1)
        {
            resultado /= 2;
            contagem++;
        }

        Console.WriteLine($"O resultado da última divisão é: {resultado}");
        Console.WriteLine($"Quantidade de divisões efetuadas: {contagem}");
    }
}