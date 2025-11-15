using System;

class Program
{
    static void Main()
    {
        Principal();
    }

    static void Principal()
    {
        int totalAprovados = 0;
        int totalReprovados = 0;
        int totalAlunos = 0;
        int c = 1;

        while (true)
        {
            Console.Write($"Informe a matrícula do {c}º aluno (9999 para encerrar): ");
            int matricula = int.Parse(Console.ReadLine());

            if (matricula == 9999) break;

            Console.Write("Informe a 1ª nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a 2ª nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Informe a 3ª nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            double mediaFinal = ((2 * nota1) + (3 * nota2) + (4 * nota3)) / 9;
            totalAlunos++;

            if (mediaFinal >= 5)
            {
                Console.WriteLine($"Matrícula: {matricula}, Média Final: {mediaFinal:F2} - APROVADO");
                totalAprovados++;
            }
            else
            {
                Console.WriteLine($"Matrícula: {matricula}, Média Final: {mediaFinal:F2} - REPROVADO");
                totalReprovados++;
            }
            c++;
        }

        Console.WriteLine($"Total de alunos: {totalAlunos}");
        Console.WriteLine($"Total de aprovados: {totalAprovados}");
        Console.WriteLine($"Total de reprovados: {totalReprovados}");
    }
}