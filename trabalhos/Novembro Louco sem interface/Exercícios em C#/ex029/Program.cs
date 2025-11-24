using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Imprimindo todos os múltiplos inteiros de 7 inferiores à 1000:");

        for (int num = 1; num < 1000; num++)
        {
            if (num % 7 == 0)
            {
                Console.WriteLine(num);
            }
        }
    }
}