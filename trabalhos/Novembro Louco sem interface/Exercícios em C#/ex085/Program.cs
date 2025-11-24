using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        string fraseRepetida = RepetirPalavras(frase);
        Console.WriteLine($"Saída: {fraseRepetida}");
    }

    static string RepetirPalavras(string frase)
    {
        string[] palavras = frase.Split(' ');
        for (int i = 0; i < palavras.Length; i++)
        {
            palavras[i] += $" {palavras[i]}";
        }
        return string.Join(" ", palavras);
    }
}