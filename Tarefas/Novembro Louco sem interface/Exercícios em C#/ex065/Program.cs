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
        string[] vetorTxt = texto.Split(' ');
        string[] listaAsteriscos = Array.ConvertAll(vetorTxt, palavra => new string('*', palavra.Length));
        string textoAsteriscos = string.Join(" ", listaAsteriscos);

        Console.WriteLine($"Caracteres substituídos por asterisco: {textoAsteriscos}");
    }
}