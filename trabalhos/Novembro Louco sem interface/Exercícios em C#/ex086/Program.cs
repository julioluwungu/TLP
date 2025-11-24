using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        string fraseDuplicada = DuplicarLetras(frase);
        Console.WriteLine($"Frase gerada: {fraseDuplicada}");
    }

    static string DuplicarLetras(string frase)
    {
        char[] resultado = new char[frase.Length * 2];
        int index = 0;

        foreach (char letra in frase)
        {
            resultado[index++] = letra;
            if (letra != ' ')
            {
                resultado[index++] = letra;
            }
        }

        return new string(resultado, 0, index);
    }
}