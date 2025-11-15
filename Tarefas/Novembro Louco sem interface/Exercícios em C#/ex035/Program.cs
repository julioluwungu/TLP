using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        Console.Write("Digite um número para ver sua tabela de multiplicação: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"Tabela de multiplicação de {numero}:");
        for (int c = 1; c <= 13; c++)
        {
            int resultado = numero * c;
            Console.WriteLine($"{numero} x {c} = {resultado}");
        }
    }
}