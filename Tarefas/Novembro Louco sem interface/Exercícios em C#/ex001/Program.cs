using System;

class Program
{
    static void Main(string[] args)
    {
        Principal().GetAwaiter().GetResult();
    }

    static async Task Principal()
    {
        int tempo;
        while (true)
        {
            Console.Write("Digite um tempo em segundos: ");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out tempo) && tempo >= 0)
                break;

            Console.WriteLine("Valor inválido! Por favor, digite um número válido!");
        }

        int horas = tempo / 3600;
        int minutos = (tempo % 3600) / 60;
        int segundos = tempo % 60;

        Console.WriteLine($"{tempo} segundos equivale a:");
        Console.WriteLine($"{horas:D2}:{minutos:D2}:{segundos:D2}");
    }
}