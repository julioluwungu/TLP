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
        int totalAlunos = 45;
        List<int> idades = new List<int>();
        List<double> alturas = new List<double>();

        for (int i = 0; i < totalAlunos; i++)
        {
            Console.Write($"Informe a idade do aluno {i + 1}: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write($"Informe a altura do aluno {i + 1} em metros: ");
            double altura = double.Parse(Console.ReadLine());

            if (altura < 1.70)
            {
                idades.Add(idade);
            }

            if (idade > 20)
            {
                alturas.Add(altura);
            }
        }

        double somaIdade = 0;
        foreach (var idade in idades)
        {
            somaIdade += idade;
        }
        double idadeMedia = idades.Count > 0 ? somaIdade / idades.Count : 0;

        double somaAltura = 0;
        foreach (var altura in alturas)
        {
            somaAltura += altura;
        }
        double alturaMedia = alturas.Count > 0 ? somaAltura / alturas.Count : 0;

        Console.WriteLine($"A idade média dos alunos com menos de 1,70 m é: {idadeMedia:F1} anos");
        Console.WriteLine($"A altura média dos alunos com mais de 20 anos é: {alturaMedia:F1} metros");
    }
}