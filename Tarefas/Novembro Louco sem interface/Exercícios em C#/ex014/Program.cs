using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        string[] palavras = new string[2];

        for (int c = 0; c < 2; c++)
        {
            Console.Write($"Digite a {c + 1}ª palavra: ");
            palavras[c] = Console.ReadLine();
        }

        if (palavras[0] == palavras[1])
        {
            Console.WriteLine("As palavras digitadas são iguais.");
        }
        else
        {
            if (palavras[0].Length > palavras[1].Length)
                Console.WriteLine($"A palavra \"{palavras[0]}\" tem maior comprimento em relação à palavra \"{palavras[1]}\".");
            else if (palavras[1].Length > palavras[0].Length)
                Console.WriteLine($"A palavra \"{palavras[1]}\" tem maior comprimento em relação à palavra \"{palavras[0]}\".");
            else
                Console.WriteLine($"A palavra \"{palavras[0]}\" e a palavra \"{palavras[1]}\" têm o mesmo comprimento.");

            if (palavras[0].Contains(palavras[1]))
                Console.WriteLine($"A palavra \"{palavras[1]}\" é uma substring da palavra \"{palavras[0]}\".");
        }
    }
}