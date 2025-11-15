using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int primeiroTermo = 3;
        int razao = 3;
        List<int> termos = new List<int>();
        int termoAtual = primeiroTermo;
        int soma = 0;

        while (termoAtual <= 6561)
        {
            termos.Add(termoAtual);
            soma += termoAtual;
            termoAtual *= razao;
        }

        Console.WriteLine($"Termos da PG: {string.Join(", ", termos)}");
        Console.WriteLine($"Soma dos termos: {soma}");
    }
}