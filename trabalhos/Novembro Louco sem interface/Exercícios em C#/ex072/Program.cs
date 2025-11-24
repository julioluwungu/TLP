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
            Console.Write("Digite um número entre 20 e 99: ");
            if (int.TryParse(Console.ReadLine(), out numero) && numero >= 20 && numero <= 99)
            {
                break;
            }
            Console.WriteLine("Número inválido. Por favor, digite um número entre 20 e 99.");
        }

        string[] unidades = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
        string[] dezenas = { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
        string extenso;

        if (numero < 30)
        {
            extenso = dezenas[2] + (numero == 20 ? "" : " e " + unidades[numero % 10]);
        }
        else
        {
            extenso = dezenas[numero / 10] +
                       (numero % 10 != 0 ? " e " + unidades[numero % 10] : "");
        }

        Console.WriteLine($"O número {numero} por extenso é: {extenso}");
    }
}