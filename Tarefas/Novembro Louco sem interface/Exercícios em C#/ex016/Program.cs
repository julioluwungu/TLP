using System;

class Program
{
    static void Main(string[] args)
    {
        double populacaoA = 80000;
        double taxaCrescimentoA = 0.03;

        double populacaoB = 200000;
        double taxaCrescimentoB = 0.015;

        int anos = 0;

        while (populacaoA < populacaoB)
        {
            populacaoA += populacaoA * taxaCrescimentoA;
            populacaoB += populacaoB * taxaCrescimentoB;
            anos++;
        }

        Console.WriteLine($"Anos necessários para a população A ultrapassar a população B: {anos}");
    }
}