using System;
using System.Collections.Generic;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        int n;
        double a1, r;

        while (true)
        {
            Console.Write("Informe o número de termos (n): ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Informe o primeiro termo (a1): ");
            a1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a razão (r): ");
            r = double.Parse(Console.ReadLine());

            if (n > 0 && !double.IsNaN(a1) && !double.IsNaN(r)) break;
            else Console.WriteLine("Valor inválido! Por favor, tente novamente!");
        }

        List<double> termos = new List<double>();
        double soma = 0;

        for (int c = 0; c < n; c++)
        {
            double termo = a1 + c * r;
            termos.Add(termo);
            soma += termo;
        }

        Console.WriteLine("Os termos da PA são: " + string.Join(", ", termos));
        Console.WriteLine("A soma dos termos é: " + soma);
    }
}