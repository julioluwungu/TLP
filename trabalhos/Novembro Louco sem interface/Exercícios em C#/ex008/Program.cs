using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> valores = new List<int>();

        for (int num = 1000; num <= 9999; num++)
        {
            string strnum = num.ToString();
            int parte1 = int.Parse(strnum[0].ToString() + strnum[1].ToString());
            int parte2 = int.Parse(strnum[2].ToString() + strnum[3].ToString());
            int resultado = (int)Math.Pow(parte1 + parte2, 2);

            if (resultado == num)
            {
                valores.Add(num);
            }
        }

        Console.WriteLine("Os números que seguem a regra são:");

        foreach (var num in valores)
        {
            Console.WriteLine(num);
        }
    }
}