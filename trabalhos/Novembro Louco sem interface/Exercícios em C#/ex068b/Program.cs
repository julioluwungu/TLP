using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        Console.Write("Digite um texto: ");
        string texto = Console.ReadLine();
        
        int numeroCaracteres = texto.Replace(" ", "").Length;
        int numeroPalavras = texto.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

        Console.WriteLine($"Número total de caracteres (sem espaços): {numeroCaracteres}");
        Console.WriteLine($"Número total de palavras: {numeroPalavras}");
    }
}