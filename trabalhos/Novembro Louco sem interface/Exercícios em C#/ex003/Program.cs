using System;

class Program
{
    static void Main(string[] args)
    {
        Principal().GetAwaiter().GetResult();
    }

    static async Task Principal()
    {
        string[] letras = { "X", "Y", "Z" };
        int[] valores = new int[3];

        for (int c = 0; c < 3; c++)
        {
            while (true)
            {
                Console.Write($"Digite o valor inteiro de {letras[c]}: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int num) && num > 0)
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

        if (
            valores[0] < valores[1] + valores[2] &&
            valores[1] < valores[0] + valores[2] &&
            valores[2] < valores[0] + valores[1]
        )
        {
            if (valores[0] == valores[1] && valores[0] == valores[2])
            {
                Console.WriteLine("Triângulo Equilátero!");
            }
            else if (valores[0] == valores[1] || valores[0] == valores[2] || valores[1] == valores[2])
            {
                Console.WriteLine("Triângulo Isósceles!");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno!");
            }
        }
        else
        {
            Console.WriteLine("Não é possível formar um triângulo com os valores fornecidos!");
        }
    }
}