using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        List<string> conectores = new List<string> { "e", "do", "da", "dos", "das", "de", "di", "du" };

        Console.Write("Digite o seu nome completo: ");
        string nome = Console.ReadLine();
        string[] palavras = nome.Split(' ');

        List<string> iniciais = palavras
            .Where(palavra => !conectores.Contains(palavra.ToLower()))
            .Select(palavra => palavra[0].ToString().ToUpper())
            .ToList();

        Console.WriteLine($"As iniciais são: {string.Join(", ", iniciais)}");
    }
}