using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        int valorSorteado;
        Random random = new Random();
        int tempoSorteado = random.Next(10);
        DateTime tempoInicial = DateTime.Now;

        await Task.Delay(tempoSorteado * 1000);
        valorSorteado = random.Next(1, 21);
        Console.WriteLine($"Agora! Valor sorteado: {valorSorteado}");

        string pergunta = "Digite o valor que apareceu na tela: ";
        tempoInicial = DateTime.Now;

        int num;
        while (true)
        {
            Console.Write(pergunta);
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out num) && num == valorSorteado)
            {
                TimeSpan tempoFeito = DateTime.Now - tempoInicial;
                Console.WriteLine($"Demorou {tempoFeito.TotalSeconds} segundos para acertar.");
                break;
            }
            else
            {
                Console.WriteLine("Valor incorreto. Por favor, digite o valor correto!");
            }
        }
    }
}