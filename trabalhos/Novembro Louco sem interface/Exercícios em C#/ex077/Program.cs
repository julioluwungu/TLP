using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        int numeroDePalavras = ContarPalavras(frase);
        Console.WriteLine($"Número de palavras: {numeroDePalavras}");
    }

    static int ContarPalavras(string frase)
    {
        string[] palavras = frase.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return palavras.Length;
    }
}