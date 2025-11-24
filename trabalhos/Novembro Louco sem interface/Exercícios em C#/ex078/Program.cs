using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();
        
        string fraseAlterada = SubstituirEspacos(frase);
        Console.WriteLine($"Frase alterada: {fraseAlterada}");
    }

    static string SubstituirEspacos(string frase)
    {
        return frase.Replace(" ", "#");
    }
}