using System;

class Program
{
    static void Main(string[] args)
    {
        int produto = 1;

        for (int c = 1; c <= 15; c++)
        {
            if (c % 2 != 0)
            {
                produto *= c;
            }
        }

        Console.WriteLine($"O produto dos inteiros ímpares de 1 a 15 é: {produto}");
    }
}