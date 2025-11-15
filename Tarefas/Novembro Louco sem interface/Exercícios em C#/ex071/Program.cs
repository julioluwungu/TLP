using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        Console.Write("Digite uma sequência de caracteres: ");
        string texto = Console.ReadLine();

        string textoLimpo = new string(texto.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();
        string textoInvertido = new string(textoLimpo.Reverse().ToArray());

        bool palindromo = textoLimpo == textoInvertido;

        Console.WriteLine($"Frase: {texto}");
        Console.WriteLine($"É um palíndromo? {(palindromo ? "Sim" : "Não")}");
    }
}