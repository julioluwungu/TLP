using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Principal().GetAwaiter().GetResult();
    }

    static async Task Principal()
    {
        string numeros;

        while (true)
        {
            Console.Write("Digite uma sequência de números: ");
            numeros = Console.ReadLine();
            if (numeros.All(char.IsDigit))
            {
                break;
            }
            else
            {
                Console.WriteLine("Valor inválido! Por favor, digite um número válido!");
            }
        }

        int[] listaNum = numeros.Select(c => (int)char.GetNumericValue(c)).ToArray();
        int soma = listaNum.Sum();

        Console.WriteLine($"A soma dos números digitados é: {soma}");
    }
}