using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        while (true)
        {
            Console.Write("Digite uma palavra (ou uma palavra que comece com \"f\" para terminar): ");
            string palavra = Console.ReadLine();

            if (string.IsNullOrEmpty(palavra)) continue;

            char primeiraLetra = palavra[0];
            char ultimaLetra = palavra[palavra.Length - 1];

            Console.WriteLine($"{palavra}: {primeiraLetra}-{ultimaLetra}");

            if (char.ToLower(primeiraLetra) == 'f') break;
        }
    }
}