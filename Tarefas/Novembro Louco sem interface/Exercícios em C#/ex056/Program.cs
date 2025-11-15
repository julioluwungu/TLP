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
        double totalSalario = 0;
        int quantidade = 0;
        int maiorIdade = -1;
        int menorIdade = 1000000;
        int mulheresComSalarioBaixo = 0;

        while (true)
        {
            Console.Write("Informe a idade (negativa para encerrar): ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 0) break;

            Console.Write("Informe o sexo (M/F): ");
            string sexo = Console.ReadLine().ToUpper();
            Console.Write("Informe o salário: ");
            double salario = double.Parse(Console.ReadLine());

            totalSalario += salario;
            quantidade++;

            if (idade > maiorIdade)
            {
                maiorIdade = idade;
            }
            if (idade < menorIdade)
            {
                menorIdade = idade;
            }

            if (sexo == "F" && salario <= 100)
            {
                mulheresComSalarioBaixo++;
            }
        }

        double mediaSalario = quantidade > 0 ? totalSalario / quantidade : 0;

        Console.WriteLine($"Média de salário do grupo: R${mediaSalario:F2}");
        Console.WriteLine($"Maior idade do grupo: {maiorIdade}");
        Console.WriteLine($"Menor idade do grupo: {menorIdade}");
        Console.WriteLine($"Quantidade de mulheres com salário até R$100,00: {mulheresComSalarioBaixo}");
    }
}