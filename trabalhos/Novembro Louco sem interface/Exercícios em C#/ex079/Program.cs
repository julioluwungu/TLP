using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a primeira string: ");
        string string1 = Console.ReadLine();

        Console.Write("Digite a segunda string: ");
        string string2 = Console.ReadLine();

        bool resultado = PalindromasMutuas(string1, string2);
        
        if (resultado)
            Console.WriteLine($"As strings \"{string1}\" e \"{string2}\" são palíndromas mútuas.");
        else
            Console.WriteLine($"As strings \"{string1}\" e \"{string2}\" não são palíndromas mútuas.");
    }

    static bool PalindromasMutuas(string str1, string str2)
    {
        char[] str2Array = str2.ToCharArray();
        Array.Reverse(str2Array);
        string str2Reversa = new string(str2Array);
        return str1 == str2Reversa;
    }
}