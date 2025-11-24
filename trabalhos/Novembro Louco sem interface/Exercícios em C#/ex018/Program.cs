using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        Console.Write("Montar a tabuada de: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Começar por: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Terminar em: ");
        int fim = int.Parse(Console.ReadLine());

        if (fim < inicio)
        {
            Console.WriteLine("O valor final não pode ser menor que o valor inicial. Tente novamente.");
            return;
        }
        else
        {
            Console.WriteLine($"Vou montar a tabuada de {numero} começando em {inicio} e terminando em {fim}:");

            for (int i = inicio; i <= fim; i++)
            {
                Console.WriteLine($"{numero} X {i} = {numero * i}");
            }
        }
    }
}