using System;
using System.Collections.Generic;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        List<Hotel> hoteis = new List<Hotel>();

        while (true)
        {
            Console.Write("Digite o nome do hotel: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a distância do hotel ao centro da cidade (em km): ");
            double distancia = double.Parse(Console.ReadLine());

            Console.Write("Digite o número médio de visitantes no último feriado: ");
            int visitantes = int.Parse(Console.ReadLine());

            Console.Write("Digite o tipo de acesso ao hotel (0 - não asfaltado, 1 - asfaltado): ");
            int acesso = int.Parse(Console.ReadLine());

            hoteis.Add(new Hotel { Nome = nome, Distancia = distancia, Visitantes = visitantes, Acesso = acesso });

            Console.Write("Deseja adicionar mais um hotel? (s/n): ");
            if (Console.ReadLine().ToLower() != "s") break;
        }

        int hoteisDistantes = hoteis.Count(hotel => hotel.Distancia > 15);
        Console.WriteLine($"Número de hotéis que distam mais de 15 km do centro: {hoteisDistantes}");

        var hotelesNaoAsfaltados = hoteis.Where(hotel => hotel.Acesso == 0).ToList();
        double mediaVisitantes = hotelesNaoAsfaltados.Count > 0 ? hotelesNaoAsfaltados.Average(hotel => hotel.Visitantes) : 0;

        Console.WriteLine($"Quantidade média de visitantes nos hotéis com acesso não asfaltado: {mediaVisitantes:F1}");

        Console.WriteLine("Hotéis asfaltados com menos de 1.000 visitantes:");
        foreach (var hotel in hoteis.Where(h => h.Acesso == 1 && h.Visitantes < 1000))
        {
            Console.WriteLine($"{hotel.Nome}, Distância: {hotel.Distancia} km");
        }
    }
}

class Hotel
{
    public string Nome { get; set; }
    public double Distancia { get; set; }
    public int Visitantes { get; set; }
    public int Acesso { get; set; }
}