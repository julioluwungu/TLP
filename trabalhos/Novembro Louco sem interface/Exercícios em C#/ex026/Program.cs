using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        List<(int codigo, string sexo, double salario_bruto, double salario_liquido)> listagem = new List<(int, string, double, double)>();
        List<double> salarioM = new List<double>();
        List<double> salarioF = new List<double>();

        while (true)
        {
            Console.Write("Digite o código (ou 99999 para sair): ");
            int codigo = int.Parse(Console.ReadLine());
            if (codigo == 99999) break;

            string sexo;
            while (true)
            {
                Console.Write("Qual o sexo? [M/F]: ");
                sexo = Console.ReadLine().Trim().ToUpper();
                if (sexo == "M" || sexo == "F") break;
                else Console.WriteLine("Sexo inválido. Por favor, tente novamente!");
            }

            Console.Write("Digite o número de horas/aulas dadas: ");
            int horas = int.Parse(Console.ReadLine());

            double salBruto = horas * 30;
            double desconto = (sexo == "M") ? 0.10 : 0.05;
            double salLiquido = salBruto * (1 - desconto);

            if (sexo == "M")
            {
                salarioM.Add(salLiquido);
            }
            else
            {
                salarioF.Add(salLiquido);
            }

            listagem.Add((codigo, sexo, salBruto, salLiquido));
        }

        double somaSalM = salarioM.Sum();
        double somaSalF = salarioF.Sum();

        double mediaSalM = salarioM.Count > 0 ? somaSalM / salarioM.Count : 0;
        double mediaSalF = salarioF.Count > 0 ? somaSalF / salarioF.Count : 0;

        Console.WriteLine("Emitindo listagem:");
        foreach (var pessoa in listagem)
        {
            Console.WriteLine($"Código: {pessoa.codigo}. Sexo: {pessoa.sexo}. Salário bruto: R$ {pessoa.salario_bruto:F1}. Salário líquido: R$ {pessoa.salario_liquido:F1}.");
        }
        Console.WriteLine($"Média dos salários líquidos do sexo masculino: R$ {mediaSalM:F1}");
        Console.WriteLine($"Média dos salários líquidos do sexo feminino: R$ {mediaSalF:F1}");
    }
}