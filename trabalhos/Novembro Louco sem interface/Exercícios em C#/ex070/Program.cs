using System;

class Program
{
    static async Task Main(string[] args)
    {
        await Principal();
    }

    static async Task Principal()
    {
        Console.Write("Digite sua data de nascimento (dd/mm/aaaa): ");
        string data = Console.ReadLine();

        string[] partes = data.Split('/');

        if (partes.Length == 3 && int.TryParse(partes[0], out int dia) && int.TryParse(partes[1], out int mes) && int.TryParse(partes[2], out int ano))
        {
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            string mesExtenso = meses[mes - 1];

            Console.WriteLine($"Você nasceu em {dia} de {mesExtenso} de {ano}");
        }
        else
        {
            Console.WriteLine("Mês inválido. Certifique-se de digitar no formato dd/mm/aaaa.");
        }
    }
}