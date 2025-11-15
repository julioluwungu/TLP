using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        Console.Write("Digite o nome da primeira pessoa: ");
        string nome1 = Console.ReadLine();

        Console.Write($"Digite a altura de {nome1} (em metros): ");
        double altura1 = double.Parse(Console.ReadLine());

        Console.Write($"Digite o peso de {nome1} (em kg): ");
        double peso1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o nome da segunda pessoa: ");
        string nome2 = Console.ReadLine();

        Console.Write($"Digite a altura de {nome2} (em metros): ");
        double altura2 = double.Parse(Console.ReadLine());

        Console.Write($"Digite o peso de {nome2} (em kg): ");
        double peso2 = double.Parse(Console.ReadLine());

        var maisPesado = peso1 >= peso2 ? new { Nome = nome1, Peso = peso1 } : new { Nome = nome2, Peso = peso2 };
        var maisAlto = altura1 >= altura2 ? new { Nome = nome1, Altura = altura1 } : new { Nome = nome2, Altura = altura2 };

        Console.WriteLine($"A pessoa mais pesada é {maisPesado.Nome} com {maisPesado.Peso} kg.");
        Console.WriteLine($"A pessoa mais alta é {maisAlto.Nome} com {maisAlto.Altura} m.");
    }
}