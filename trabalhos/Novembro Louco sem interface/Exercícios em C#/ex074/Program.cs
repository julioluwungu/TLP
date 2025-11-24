using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        int espacos = frase.Count(c => c == ' ');

        Console.WriteLine($"Número de espaços em branco: {espacos}");
    }
}