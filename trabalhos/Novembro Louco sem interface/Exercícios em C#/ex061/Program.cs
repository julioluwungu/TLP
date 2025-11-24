using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        int numAndares;
        int totalPessoas = 0;

        while (true)
        {
            Console.Write("Informe o número de andares do prédio: ");
            if (int.TryParse(Console.ReadLine(), out numAndares) && numAndares > 0)
            {
                break;
            }
            Console.WriteLine("Valor inválido! Por favor, digite um número válido de andares.");
        }

        for (int andar = 1; andar <= numAndares; andar++)
        {
            Console.WriteLine($"\nAndar {andar}:");
            Console.Write($"Número de pessoas que entraram no elevador no {andar}º andar: ");
            int entraram = int.Parse(Console.ReadLine());

            Console.Write($"Número de pessoas que saíram do elevador no {andar}º andar: ");
            int sairam = int.Parse(Console.ReadLine());

            totalPessoas += entraram - sairam;

            if (totalPessoas > 15)
            {
                int excesso = totalPessoas - 15;
                Console.WriteLine($"Excesso de passageiros! Deve sair {excesso} pessoas.");
                totalPessoas -= excesso;
            }

            if (totalPessoas < 0)
            {
                totalPessoas = 0;
            }
        }

        Console.WriteLine($"\nNúmero de pessoas que irão descer no último andar: {totalPessoas}");
    }
}