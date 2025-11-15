using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        Console.Write("Informe a quantidade de funcionários: ");
        int quantidadeFuncionarios = int.Parse(Console.ReadLine());
        List<double> salarios = new List<double>();

        for (int c = 0; c < quantidadeFuncionarios; c++)
        {
            Console.Write($"Digite o nome do {c + 1}º funcionário: ");
            string nome = Console.ReadLine();

            Console.Write($"Informe o salário de {nome}: ");
            double salario = double.Parse(Console.ReadLine());

            salarios.Add(salario);
        }

        double somaSalarios = salarios.Sum();
        double mediaSalarios = somaSalarios / salarios.Count;
        double salarioMaisAlto = salarios.Max();
        double salarioMaisBaixo = salarios.Min();

        Console.WriteLine($"Média dos salários: R$ {mediaSalarios:F1}");
        Console.WriteLine($"Salário mais alto: R$ {salarioMaisAlto:F1}");
        Console.WriteLine($"Salário mais baixo: R$ {salarioMaisBaixo:F1}");
    }
}