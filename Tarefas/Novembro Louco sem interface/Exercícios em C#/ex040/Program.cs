using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        int numero1;
        int numero2;

        while (true)
        {
            Console.Write("Digite o primeiro número inteiro: ");
            if (int.TryParse(Console.ReadLine(), out numero1))
            {
                Console.Write("Digite o segundo número inteiro: ");
                if (int.TryParse(Console.ReadLine(), out numero2))
                {
                    break;
                }
            }
            Console.WriteLine("Entrada inválida! Por favor, digite números inteiros válidos.");
        }

        int resultado = 0;

        for (int i = 0; i < Math.Abs(numero2); i++)
        {
            resultado += numero1;
        }

        if (numero2 < 0)
        {
            resultado = -resultado;
        }

        Console.WriteLine($"O resultado da multiplicação de {numero1} por {numero2} é: {resultado}");
    }
}