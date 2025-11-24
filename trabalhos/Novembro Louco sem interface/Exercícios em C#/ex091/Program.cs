using System;

class Program
{
    static void Main()
    {
        double numero;

        while (true)
        {
            Console.Write("Digite um número: ");
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out numero))
                break;
            else
                Console.WriteLine("Valor inválido! Por favor, digite um número válido.");
        }

        bool triangular = false;

        for (int x = 1; x < Math.Cbrt(numero) + 1; x++)
        {
            double produto = x * (x + 1) * (x + 2);
            if (produto == numero)
            {
                triangular = true;
                Console.WriteLine($"O número {numero} é um número triangular: {x} x {x + 1} x {x + 2} = {produto}");
                break;
            }
        }

        if (!triangular)
        {
            Console.WriteLine($"O número {numero} não é um número triangular.");
        }
    }
}