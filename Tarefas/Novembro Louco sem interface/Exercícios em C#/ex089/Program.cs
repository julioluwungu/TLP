using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        string fraseSemEspacos = RemoverEspacos(frase);
        Console.WriteLine($"Frase sem espaços em branco: {fraseSemEspacos}");
    }

    static string RemoverEspacos(string frase)
    {
        return frase.Replace(" ", "");
    }
}