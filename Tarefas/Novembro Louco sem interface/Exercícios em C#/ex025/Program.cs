using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        List<double> valores = new List<double>();

        while (true)
        {
            Console.Write("Digite um número (ou \"sair\" para encerrar): ");
            string entrada = Console.ReadLine();

            if (entrada.ToLower() == "sair")
            {
                break;
            }

            if (double.TryParse(entrada, out double numero))
            {
                valores.Add(numero);
            }
            else
            {
                Console.WriteLine("Valor inválido! Por favor, insira um número.");
            }
        }

        double soma = valores.Sum();
        double media = valores.Count > 0 ? soma / valores.Count : 0;
        var positivos = valores.Where(num => num > 0).ToList();
        var negativos = valores.Where(num => num < 0).ToList();

        double percentualPositivo = (positivos.Count * 100) / (double)valores.Count;
        double percentualNegativo = (negativos.Count * 100) / (double)valores.Count;

        Console.WriteLine($"Média Aritmética: {media:F1}");
        Console.WriteLine($"Quantidade de Valores Positivos: {positivos.Count}");
        Console.WriteLine($"Quantidade de Valores Negativos: {negativos.Count}");
        Console.WriteLine($"Percentual de Valores Positivos: {percentualPositivo:F1}%");
        Console.WriteLine($"Percentual de Valores Negativos: {percentualNegativo:F1}%");
    }
}