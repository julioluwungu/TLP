using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        Console.Write("Digite seu nome completo: ");
        string nomeCompleto = Console.ReadLine().Trim();
        
        string[] partes = nomeCompleto.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (partes.Length > 1)
        {
            string sobrenome = partes[^1]; // Usando o operador de índice de final
            Console.WriteLine($"Sobrenome: {sobrenome}");
        }
        else
        {
            Console.WriteLine("Sobrenome não encontrado. Certifique-se de digitar um nome completo.");
        }
    }
}