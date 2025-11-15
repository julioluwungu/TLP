using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        string fraseModificada = ModificarFrase(frase);
        Console.WriteLine($"Frase transformada: {fraseModificada}");
    }

    static string ModificarFrase(string frase)
    {
        char[] resultado = new char[frase.Length];
        int index = 0;

        foreach (char letra in frase)
        {
            resultado[index++] = "aeiouAEIOU".Contains(letra) ? '!' : letra;
        }

        return new string(resultado, 0, index).ToUpper();
    }
}