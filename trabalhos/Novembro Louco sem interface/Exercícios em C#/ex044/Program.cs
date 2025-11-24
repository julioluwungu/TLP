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
            Console.Write("Digite o primeiro número inteiro positivo: ");
            if (int.TryParse(Console.ReadLine(), out numero1) && numero1 > 0)
            {
                Console.Write("Digite o segundo número inteiro positivo: ");
                if (int.TryParse(Console.ReadLine(), out numero2) && numero2 > 0)
                {
                    break;
                }
            }
            Console.WriteLine("Entrada inválida! Por favor, digite números inteiros válidos.");
        }

        int quociente = 0;
        int resto = numero1;

        while (resto >= numero2)
        {
            resto -= numero2;
            quociente++;
        }

        Console.WriteLine($"Quociente: {quociente}");
        Console.WriteLine($"Resto: {resto}");
    }
}