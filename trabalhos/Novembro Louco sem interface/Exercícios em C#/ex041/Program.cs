using System;

class Program
{
    static void Main(string[] args)
    {
        int[] fibonacci = new int[20];
        fibonacci[0] = 0;
        fibonacci[1] = 1;

        for (int c = 2; c < 20; c++)
        {
            fibonacci[c] = fibonacci[c - 1] + fibonacci[c - 2];
        }

        Console.WriteLine("Os 20 primeiros termos da sequência de Fibonacci são:");
        foreach (var termo in fibonacci)
        {
            Console.WriteLine(termo);
        }
    }
}