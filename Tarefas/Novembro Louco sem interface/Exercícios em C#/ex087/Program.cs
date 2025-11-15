using System;

class Program
{
    static void Main()
    {
        string verbo;

        while (true)
        {
            Console.Write("Digite um verbo regular terminado em ER: ");
            verbo = Console.ReadLine().ToUpper();

            if (verbo.EndsWith("ER")) break;
            else Console.WriteLine("Por favor, insira um verbo regular que termine em \"ER\".");
        }

        string radical = verbo.Substring(0, verbo.Length - 2).ToLower();

        Console.WriteLine($"Conjugação do verbo \"{verbo}\" no presente:");
        Console.WriteLine($"Eu {radical}o");
        Console.WriteLine($"Tu {radical}es");
        Console.WriteLine($"Ele {radical}e");
        Console.WriteLine($"Ela {radical}e");
        Console.WriteLine($"Nós {radical}emos");
        Console.WriteLine($"Vós {radical}eis");
        Console.WriteLine($"Eles {radical}em");
        Console.WriteLine($"Elas {radical}em");
    }
}