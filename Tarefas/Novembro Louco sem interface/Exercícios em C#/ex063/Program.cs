using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Imprimindo os quadrados e cubos dos números entre 0 e 10:");
        for (int num = 0; num <= 10; num++)
        {
            Console.WriteLine($"{num} === {num * num} === {num * num * num}");
        }
    }
}