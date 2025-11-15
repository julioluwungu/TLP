using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        double massa;

        while (true)
        {
            Console.Write("Informe a massa inicial em gramas: ");
            if (double.TryParse(Console.ReadLine(), out massa) && massa > 0)
            {
                break;
            }
            Console.WriteLine("Valor inválido! Por favor, digite um valor válido maior que zero.");
        }

        double tempoTotal = 0;
        double tempoMeio = 50;

        while (massa >= 0.05)
        {
            massa /= 2;
            tempoTotal += tempoMeio;
        }

        Console.WriteLine($"O tempo necessário para que a massa seja menor que 0,05 gramas é: {tempoTotal} segundos");
    }
}