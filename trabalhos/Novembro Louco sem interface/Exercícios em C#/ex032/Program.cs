using System;

class Program
{
    static void Main(string[] args)
    {
        ulong graos = 0;
        ulong total = 0;

        for (int quadro = 1; quadro <= 64; quadro++)
        {
            graos = (ulong)Math.Pow(2, quadro - 1);
            total += graos;
        }

        Console.WriteLine($"O Monge recebeu um total de {total} grãos.");
    }
}