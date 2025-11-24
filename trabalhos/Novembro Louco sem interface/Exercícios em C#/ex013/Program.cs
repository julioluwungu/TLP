using System;
using System.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        Console.Write("Digite o seu nome completo: ");
        string nomeCompleto = Console.ReadLine();

        var listaNomes = nomeCompleto.Split(' ');

        var nomesAbbr = listaNomes.Select(nome => 
            nome.Length > 2 ? $"{nome[0].ToString().ToUpper()}." : nome
        );

        Console.WriteLine($"Abreviação: {string.Join(' ', nomesAbbr)}");
    }
}