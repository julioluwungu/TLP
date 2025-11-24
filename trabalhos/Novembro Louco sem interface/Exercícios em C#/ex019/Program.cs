using System;
using System.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        Console.Write("Digite uma string: ");
        string texto = Console.ReadLine().Trim().ToLower();

        char[] listaTxt = texto.ToCharArray();

        var digitos = listaTxt.Where(elemento => char.IsDigit(elemento)).ToArray();
        bool palindromo = texto == new string(listaTxt.Reverse().ToArray());
        var vogais = listaTxt.Where(elemento => "aeiou".Contains(elemento)).ToArray();

        Console.WriteLine($"a) Número de caracteres: {texto.Length}");
        Console.WriteLine($"b) String em maiúsculo: {texto.ToUpper()}");
        Console.WriteLine($"c) Número de vogais: {vogais.Length}");
        Console.WriteLine($"d) A string começa com \"UNI\": {texto.ToUpper().StartsWith("UNI")}");
        Console.WriteLine($"e) A string termina com \"RIO\": {texto.ToUpper().EndsWith("RIO")}");
        Console.WriteLine($"f) Número de dígitos: {digitos.Length}");
        Console.WriteLine($"g) A string é um palíndromo: {palindromo}");
    }
}