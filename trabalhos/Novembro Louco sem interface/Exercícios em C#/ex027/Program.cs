using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;
        for (int num = 1; num <= 100; num++)
        {
            soma += num;
        }

        Console.WriteLine($"A soma dos números entre 1 e 100 é: {soma}");
    }
}