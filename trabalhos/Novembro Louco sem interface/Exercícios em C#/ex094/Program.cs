using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int numN;

        while (true)
        {
            Console.Write("Digite quantos valores devem ser lidos: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out numN) && numN > 0)
                break;
            else
                Console.WriteLine("Valor inválido! Por favor, digite um número inteiro válido.");
        }

        List<int> listaFatorial = new List<int>();
        List<int> listaValores = new List<int>();

        for (int i = 0; i < numN; i++)
        {
            int valor;

            while (true)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                string entradaValor = Console.ReadLine();
                if (int.TryParse(entradaValor, out valor) && valor > 0)
                    break;
                else
                    Console.WriteLine("Valor inválido! Por favor, digite um número inteiro válido.");
            }

            listaValores.Add(valor);
            listaFatorial.Add(CalcularFatorial(valor));
        }

        Console.WriteLine("-------------------");
        Console.WriteLine("Valor\tFatorial");
        Console.WriteLine("-------------------");
        for (int pos = 0; pos < listaFatorial.Count; pos++)
        {
            Console.WriteLine($"{listaValores[pos]}\t{listaFatorial[pos]}");
        }
    }

    static int CalcularFatorial(int numero)
    {
        if (numero <= 1) return 1;
        return numero * CalcularFatorial(numero - 1);
    }
}