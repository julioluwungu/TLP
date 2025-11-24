using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        int numero;

        while (true)
        {
            Console.Write("Digite um número para calcular o fatorial: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                break;
            }
            Console.WriteLine("Valor inválido! Por favor, digite um valor inteiro válido.");
        }

        if (numero < 0)
        {
            Console.WriteLine("Fatorial não é definido para números negativos.");
        }
        else
        {
            long fatorial = 1;

            for (int c = 1; c <= numero; c++)
            {
                fatorial *= c;
            }

            Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
        }
    }
}