using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        string nomeInvertido = new string(nome.ToCharArray().Reverse().ToArray()).ToUpper();

        Console.WriteLine($"Seu nome ao contrário é: {nomeInvertido}");
    }
}