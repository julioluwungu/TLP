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
        List<Funcionario> funcionarios = new List<Funcionario>();

        while (true)
        {
            Console.Write("Digite o nome do funcionário (ou 'fim' para encerrar): ");
            string nome = Console.ReadLine();

            if (nome.ToLower() == "fim") break;

            Console.Write($"Digite o salário de {nome}: ");
            if (double.TryParse(Console.ReadLine(), out double salario))
            {
                funcionarios.Add(new Funcionario { Nome = nome, Salario = salario });
            }
            else
            {
                Console.WriteLine("Salário inválido! Por favor, insira um número.");
            }
        }

        if (funcionarios.Count > 0)
        {
            double totalSalarios = funcionarios.Sum(funcionario => funcionario.Salario);
            double salarioMaisAlto = funcionarios.Max(funcionario => funcionario.Salario);
            double salarioMaisBaixo = funcionarios.Min(funcionario => funcionario.Salario);
            double mediaSalarios = totalSalarios / funcionarios.Count;

            Console.WriteLine($"Média de salários: {mediaSalarios:F1}");
            Console.WriteLine($"Salário mais alto: {salarioMaisAlto:F1}");
            Console.WriteLine($"Salário mais baixo: {salarioMaisBaixo:F1}");
        }
        else
        {
            Console.WriteLine("Nenhum funcionário foi registrado.");
        }
    }
}

class Funcionario
{
    public string Nome { get; set; }
    public double Salario { get; set; }
}