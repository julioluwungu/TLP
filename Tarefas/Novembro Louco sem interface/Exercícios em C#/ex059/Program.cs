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
        int maiorIdade = -1;
        int qtdMulheres18_35 = 0;
        int qtdVerdeLouros = 0;

        while (true)
        {
            Console.Write("Informe a idade (ou -1 para encerrar): ");
            if (int.TryParse(Console.ReadLine(), out int idade) && idade == -1) 
                break;

            Console.Write("Informe o sexo (M/F): ");
            string sexo = Console.ReadLine().ToUpper();

            Console.Write("Informe a cor dos olhos ([1] azuis, [2] verdes ou [3] castanhos): ");
            int corOlhos = int.Parse(Console.ReadLine());

            Console.Write("Informe a cor dos cabelos ([1] loiro, [2] castanho ou [3] preto): ");
            int corCabelos = int.Parse(Console.ReadLine());

            if (idade > maiorIdade)
            {
                maiorIdade = idade;
            }

            if (sexo == "F" && idade >= 18 && idade <= 35)
            {
                qtdMulheres18_35++;
            }

            if (corOlhos == 2 && corCabelos == 1)
            {
                qtdVerdeLouros++;
            }
        }

        Console.WriteLine($"A maior idade dos habitantes é: {maiorIdade}");
        Console.WriteLine($"Quantidade de mulheres entre 18 e 35 anos: {qtdMulheres18_35}");
        Console.WriteLine($"Quantidade de indivíduos com olhos verdes e cabelos louros: {qtdVerdeLouros}");
    }
}