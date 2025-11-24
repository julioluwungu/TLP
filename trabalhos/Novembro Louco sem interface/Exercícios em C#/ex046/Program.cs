using System;

class Program
{
    static void Main(string[] args)
    {
        int cont = 1;
        int soma = 0;

        do
        {
            soma += cont;
            cont++;
        } while (cont != 11);

        Console.WriteLine($"A soma dos números de 1 à 10 é de: {soma}");
    }
}