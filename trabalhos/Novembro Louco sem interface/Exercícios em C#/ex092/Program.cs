using System;

class Program
{
    static void Main()
    {
        int somaPares = 0;
        int somaPrimos = 0;

        for (int c = 0; c < 10; c++)
        {
            double numero;

            while (true)
            {
                Console.Write($"Digite o {c + 1} número: ");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out numero))
                    break;
                else
                    Console.WriteLine("Valor inválido! Por favor, digite um número válido.");
            }

            if (numero % 2 == 0)
            {
                somaPares += (int)numero;
            }

            if (EhPrimo((int)numero))
            {
                somaPrimos += (int)numero;
            }
        }

        Console.WriteLine($"Soma dos números pares: {somaPares}");
        Console.WriteLine($"Soma dos números primos: {somaPrimos}");
    }

    static bool EhPrimo(int numero)
    {
        if (numero <= 1) return false;
        for (int c = 2; c <= Math.Sqrt(numero); c++)
        {
            if (numero % c == 0) return false;
        }
        return true;
    }
}