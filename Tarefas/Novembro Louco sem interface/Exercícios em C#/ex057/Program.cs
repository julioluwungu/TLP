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
            Console.Write("Informe um número inteiro N: ");
            if (int.TryParse(Console.ReadLine(), out numN) && numN >= 0)
            {
                break;
            }
            Console.WriteLine("Valor inválido! Por favor, digite um número inteiro não negativo.");
        }

        int maiorQuadrado = (int)Math.Floor(Math.Sqrt(numN));
        maiorQuadrado *= maiorQuadrado;

        Console.WriteLine($"O maior quadrado menor ou igual a {numN} é: {maiorQuadrado}");
    }
}