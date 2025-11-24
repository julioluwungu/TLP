using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        List<string> nomes = new List<string>();

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o nome da pessoa {i + 1}: ");
            string nome = Console.ReadLine();
            nomes.Add(nome);
        }

        Console.Write("Digite um nome para verificar: ");
        string verificarNome = Console.ReadLine();

        if (nomes.Contains(verificarNome))
        {
            Console.WriteLine("ACHEI");
        }
        else
        {
            Console.WriteLine("NÃO ACHEI");
        }
    }
}