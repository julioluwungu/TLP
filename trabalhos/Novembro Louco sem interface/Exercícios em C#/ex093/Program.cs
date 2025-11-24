using System;

class Program
{
    static void Main()
    {
        double numero;

        while (true)
        {
            Console.Write("Digite um número positivo: ");
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out numero) && numero > 0)
                break;
            else
                Console.WriteLine("Valor inválido! Por favor, digite um número válido.");
        }

        Console.WriteLine($"Contagem regressiva pulando de 2 em 2 começando de {numero}:");
        for (int c = (int)numero; c >= 0; c -= 2)
        {
            Console.WriteLine(c);
        }
    }
}