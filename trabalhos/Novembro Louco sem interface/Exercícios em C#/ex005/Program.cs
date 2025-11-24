using System;

class Program
{
    static void Main(string[] args)
    {
        Principal().GetAwaiter().GetResult();
    }

    static async Task Principal()
    {
        double[] valores = new double[2];
        string strOperacoes = "+-*/";
        string operacao;

        while (true)
        {
            Console.Write("Escolha uma operação (+, -, *, /): ");
            operacao = Console.ReadLine();
            if (strOperacoes.Contains(operacao))
            {
                break;
            }
            else
            {
                Console.WriteLine("Operação inválida. Por favor, tente novamente!");
            }
        }

        for (int c = 0; c < 2; c++)
        {
            while (true)
            {
                Console.Write($"Digite o {c + 1}º valor: ");
                if (double.TryParse(Console.ReadLine(), out double num))
                {
                    valores[c] = num;
                    break;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Por favor, digite um número válido!");
                }
            }
        }

        double resultado = operacao switch
        {
            "+" => valores[0] + valores[1],
            "-" => valores[0] - valores[1],
            "*" => valores[0] * valores[1],
            "/" => valores[0] / valores[1],
            _ => 0
        };

        Console.WriteLine($"Resultado: {resultado}");
    }
}