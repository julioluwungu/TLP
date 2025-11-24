using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        int numN;

        while (true)
        {
            Console.Write("Informe um valor inteiro e positivo para N: ");
            if (int.TryParse(Console.ReadLine(), out numN) && numN >= 0)
            {
                break;
            }
            Console.WriteLine("Valor inválido! Por favor, digite um número inteiro positivo.");
        }

        double numE = 1; // Inicializando E
        double fatorial = 1;

        for (int c = 1; c <= numN; c++)
        {
            fatorial *= c;
            numE += 1 / fatorial;
        }

        Console.WriteLine($"O valor de E é: {numE:F6}");
    }
}