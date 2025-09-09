using System;

class Program
{
    static void Main()
    {
        Televisao tv = new Televisao(55)
        {
            Resolucao = 1080
        };

        tv.Ligar();

        // Agora ajusta o volume direto para 50, sem mostrar cada passo
        tv.DefinirVolume(50);

        tv.PassarCanalCima();
        tv.PassarCanalCima();
        tv.PassarCanalBaixo();

        tv.IrParaCanal(100);

        tv.AtivarMute();
        tv.AtivarMute();

        tv.Desligar();

        Console.WriteLine("Programa finalizado.");
    }
}
