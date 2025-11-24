using System;

class Program
{
    static void Main()
    {
        int soma = 0;

        for (int num = 1; num <= 500; num++)
        {
            if (num % 2 != 0 && num % 3 == 0)
            {
                soma += num;
            }
        }

        Console.WriteLine($"A soma dos números ímpares que são múltiplos de três de 1 até 500 é: {soma}");
    }
}