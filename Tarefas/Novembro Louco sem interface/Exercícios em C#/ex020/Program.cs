using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            string sequencia = $"{i}, ";
            for (int j = 1; j <= 10; j++)
            {
                sequencia += j;
                if (j < 10)
                {
                    sequencia += ' ';
                }
            }
            Console.WriteLine(sequencia);
        }
    }
}