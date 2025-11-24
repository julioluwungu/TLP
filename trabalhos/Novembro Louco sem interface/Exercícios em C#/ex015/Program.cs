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
        Console.Write("Digite uma lista de nomes separados por vírgula: ");
        string nomesInput = Console.ReadLine();

        var listaNomes = nomesInput.Split(',')
                                    .Select(nome => nome.Trim())
                                    .OrderBy(nome => nome)
                                    .ToList();
        
        Console.WriteLine($"Lista de nomes em ordem alfabética: {string.Join(", ", listaNomes)}");
    }
}