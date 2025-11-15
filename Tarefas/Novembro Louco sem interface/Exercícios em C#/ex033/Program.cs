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
        Console.Write("Deseja qual variação do código? (1, 2, 3 ou 4): ");
        if (int.TryParse(Console.ReadLine(), out int variacao))
        {
            switch (variacao)
            {
                case 1:
                    await CasoUm();
                    break;
                case 2:
                    Console.WriteLine("Nenhum código disponível para esta opção.");
                    break;
                case 3:
                    await CasoTres();
                    break;
                case 4:
                    await CasoQuatro();
                    break;
                default:
                    Console.WriteLine("Opção inválida! Por favor, tente novamente.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida!");
        }
    }

    static async Task CasoUm()
    {
        for (int c = 0; c < 10; c++)
        {
            Console.Write("Informe o valor de A: ");
            double numA = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de B: ");
            double numB = double.Parse(Console.ReadLine());

            if (numB == 0)
            {
                Console.WriteLine("Divisão por zero não é permitida, tente novamente.");
                c--;
                continue;
            }

            double modulo = numA % numB;
            Console.WriteLine($"O resultado do módulo é: {modulo}");
        }
    }

    static async Task CasoTres()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write("Informe o valor de A: ");
                double numA = double.Parse(Console.ReadLine());
                Console.Write("Informe o valor de B: ");
                double numB = double.Parse(Console.ReadLine());

                if (numB == 0)
                {
                    Console.WriteLine("Divisão por zero não é permitida, tente novamente.");
                    j--;
                    continue;
                }

                double modulo = numA % numB;
                Console.WriteLine($"O resto da divisão será de: {modulo}");
            }
        }
    }

    static async Task CasoQuatro()
    {
        Console.Write("Informe quantas vezes deseja executar: ");
        int numN = int.Parse(Console.ReadLine());

        for (int c = 0; c < numN; c++)
        {
            Console.Write("Informe o valor de A: ");
            double numA = double.Parse(Console.ReadLine());
            Console.Write("Informe o valor de B: ");
            double numB = double.Parse(Console.ReadLine());

            if (numB == 0)
            {
                Console.WriteLine("Divisão por zero não é permitida, tente novamente.");
                c--;
                continue;
            }

            double modulo = numA % numB;
            Console.WriteLine($"O resto da divisão será de: {modulo}");
        }
    }
}