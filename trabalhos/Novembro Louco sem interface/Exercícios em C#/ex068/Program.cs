using System;

class Frase
{
    public async Task Principal()
    {
        Console.Write("Digite uma frase qualquer: ");
        string frase = Console.ReadLine();
        string palavra;

        while (true)
        {
            Console.Write("Digite uma palavra que exista na frase: ");
            palavra = Console.ReadLine();

            if (frase.Contains(palavra)) break;
            else Console.WriteLine("Digite uma palavra que exista na frase!");
        }

        string[] vetorFrase = frase.Split(' ');
        int indice = Array.IndexOf(vetorFrase, palavra);

        Console.WriteLine($"A palavra \"{palavra}\" encontra-se com o índice {indice}");
    }
}

class Program
{
    static async Task Main(string[] args)
    {
        Frase instanciaFrase = new Frase();
        await instanciaFrase.Principal();
    }
}