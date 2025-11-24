using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        double diaria = 50;
        double totalGanhoHotel = 0;

        while (true)
        {
            Console.Write("Informe o nome do cliente (ou 'sair' para encerrar): ");
            string nome = Console.ReadLine();
            if (nome.ToLower() == "sair")
            {
                break;
            }

            Console.Write("Informe o número de diárias: ");
            if (int.TryParse(Console.ReadLine(), out int numDiarias) && numDiarias > 0)
            {
                double taxaServico;
                if (numDiarias < 15)
                {
                    taxaServico = 4;
                }
                else if (numDiarias == 15)
                {
                    taxaServico = 3.6;
                }
                else
                {
                    taxaServico = 3;
                }

                double totalConta = (diaria + taxaServico) * numDiarias;
                totalGanhoHotel += totalConta;

                Console.WriteLine($"\nNome do cliente: {nome}");
                Console.WriteLine($"Total da conta: R$ {totalConta:F2}");
            }
            else
            {
                Console.WriteLine("Número de diárias inválido!");
            }
        }

        Console.WriteLine($"\nTotal ganho pelo hotel: R$ {totalGanhoHotel:F2}");
    }
}