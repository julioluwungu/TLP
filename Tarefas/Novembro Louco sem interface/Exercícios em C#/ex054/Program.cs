using System;

class Program
{
    static void Main(string[] args)
    {
        double alturaChico = 1.50;
        double alturaZe = 1.10;
        double crescimentoChico = 0.02;
        double crescimentoZe = 0.03;
        int anos = 0;

        while (alturaZe <= alturaChico)
        {
            alturaChico += crescimentoChico;
            alturaZe += crescimentoZe;
            anos++;
        }

        Console.WriteLine($"Serão necessários {anos} anos para que Zé seja maior que Chico.");
    }
}