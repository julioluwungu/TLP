using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        int num1 = (int)ObterNumero();
        
        Console.Write("Digite o segundo número: ");
        int num2 = (int)ObterNumero();

        int soma = SomarSemSoma(num1, num2);
        Console.WriteLine($"A soma de {num1} e {num2} é: {soma}");
        
        string tipo = soma % 2 == 0 ? "par" : "ímpar";
        Console.WriteLine($"A soma é {tipo}.");
    }

    static double ObterNumero()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double resultado))
            {
                return resultado;
            }
            Console.WriteLine("Valor inválido! Por favor, digite um número válido.");
        }
    }

    static int SomarSemSoma(int a, int b)
    {
        while (b != 0)
        {
            int carry = a & b;
            a = a ^ b;
            b = carry << 1;
        }
        return a;
    }
}