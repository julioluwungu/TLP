using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> fibonacci = new List<int> { 0, 1 };

        for (int c = 2; c < 15; c++)
        {
            int proximoTermo = fibonacci[c - 1] + fibonacci[c - 2];
            fibonacci.Add(proximoTermo);
        }

        Console.WriteLine("Os 15 primeiros termos da sequência de Fibonacci são:");
        foreach (var termo in fibonacci)
        {
            Console.WriteLine(termo);
        }
    }
}