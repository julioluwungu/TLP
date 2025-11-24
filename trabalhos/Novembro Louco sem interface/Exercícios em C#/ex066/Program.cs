using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        Console.Write("Digite uma frase ou uma palavra qualquer: ");
        string texto = Console.ReadLine();

        string textoModificado = System.Text.RegularExpressions.Regex.Replace(texto, "[bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ]", "&");

        Console.WriteLine($"Consoantes substituídas por &: {textoModificado}");
    }
}