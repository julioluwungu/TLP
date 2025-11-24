using System;
using System.Timers;

class Program
{
    private static System.Timers.Timer timer;

    static void Main()
    {
        timer = new System.Timers.Timer(1000);
        timer.Elapsed += (sender, e) => AtualizarHora();
        timer.Start();

        Console.WriteLine("Pressione [Enter] para sair...");
        Console.ReadLine();
    }

    static void AtualizarHora()
    {
        DateTime agora = DateTime.Now;
        string horaFormatada = agora.ToString("HH:mm:ss");
        Console.WriteLine(horaFormatada);
    }
}
