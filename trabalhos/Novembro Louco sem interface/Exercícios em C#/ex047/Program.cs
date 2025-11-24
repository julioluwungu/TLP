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
        List<int> alunos = new List<int>();
        int numAlunos;

        while (true)
        {
            Console.Write("Digite o número de alunos: ");
            if (int.TryParse(Console.ReadLine(), out numAlunos) && numAlunos > 0)
            {
                break;
            }
            Console.WriteLine("Entrada inválida! Por favor, digite um número válido de alunos.");
        }

        Console.WriteLine("Digite o número de vezes que cada aluno utilizou o restaurante:");

        while (alunos.Count < numAlunos)
        {
            Console.Write($"Aluno {alunos.Count + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int uso) && uso >= 0)
            {
                alunos.Add(uso);
            }
            else
            {
                Console.WriteLine("Número inválido! Por favor, digite um valor válido.");
            }
        }

        int menosQue10 = alunos.Count(aluno => aluno < 10);
        int entre10e15 = alunos.Count(aluno => aluno >= 10 && aluno <= 15);
        int acimaDe15 = alunos.Count(aluno => aluno > 15);

        int totalAlunos = alunos.Count;
        double percentualMenosQue10 = (menosQue10 * 100.0) / totalAlunos;
        double percentualEntre10e15 = (entre10e15 * 100.0) / totalAlunos;
        double percentualAcimaDe15 = (acimaDe15 * 100.0) / totalAlunos;

        Console.WriteLine($"a) Percentual de alunos que utilizaram menos que 10 vezes: {percentualMenosQue10:F1}%");
        Console.WriteLine($"b) Percentual de alunos que utilizaram entre 10 e 15 vezes: {percentualEntre10e15:F1}%");
        Console.WriteLine($"c) Percentual de alunos que utilizaram mais de 15 vezes: {percentualAcimaDe15:F1}%");
    }
}