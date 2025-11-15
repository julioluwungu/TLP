using System;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0;
        Console.WriteLine("Os números pares compreendidos entre 85 e 31 são:");

        for (int num = 85; num >= 31; num--)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
                soma += num;
            }
        }

        Console.WriteLine($"E a sua soma deu: {soma}");
    }
}