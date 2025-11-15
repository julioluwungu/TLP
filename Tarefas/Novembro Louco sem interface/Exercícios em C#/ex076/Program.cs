using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static string SubstituirUltimaOcorrencia(string frase, string palavraAntiga, string palavraNova)
    {
        int ultimaOcorrencia = frase.LastIndexOf(palavraAntiga);

        if (ultimaOcorrencia == -1)
        {
            return frase;
        }

        return frase.Substring(0, ultimaOcorrencia) + palavraNova + frase.Substring(ultimaOcorrencia + palavraAntiga.Length);
    }

    static async Task Principal()
    {
        Console.Write("Digite uma frase: ");
        string frase = Console.ReadLine();

        Console.Write("Digite a palavra antiga: ");
        string palavraAntiga = Console.ReadLine();

        Console.Write("Digite a palavra nova: ");
        string palavraNova = Console.ReadLine();

        string resultado = SubstituirUltimaOcorrencia(frase, palavraAntiga, palavraNova);
        Console.WriteLine($"Resultado: {resultado}");
    }
}