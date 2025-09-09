using System;

public class Televisao
{
    private const int CANAL_MAX = 520;
    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;

    private int _ultimoCanal = 1;
    private bool _mute = false;

    public float Tamanho { get; }
    public int Resolucao { get; set; }
    public int Canal { get; private set; } = 1;
    public int Volume { get; private set; } = 20;
    public bool Estado { get; private set; } = false;

    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
    }

    // Liga/desliga
    public void Ligar()
    {
        Estado = true;
        Canal = _ultimoCanal;
        Console.WriteLine($"TV ligada no canal {Canal}, volume {Volume}.");
    }

    public void Desligar()
    {
        Estado = false;
        Console.WriteLine("TV desligada.");
    }

    // Canais
    public void PassarCanalCima()
    {
        if (!Estado) return;
        Canal = (Canal < CANAL_MAX) ? Canal + 1 : 1;
        _ultimoCanal = Canal;
        Console.WriteLine($"Canal atual: {Canal}");
    }

    public void PassarCanalBaixo()
    {
        if (!Estado) return;
        Canal = (Canal > 1) ? Canal - 1 : CANAL_MAX;
        _ultimoCanal = Canal;
        Console.WriteLine($"Canal atual: {Canal}");
    }

    public void IrParaCanal(int canal)
    {
        if (!Estado) return;
        if (canal >= 1 && canal <= CANAL_MAX)
        {
            Canal = canal;
            _ultimoCanal = canal;
            Console.WriteLine($"Canal alterado para: {Canal}");
        }
        else
        {
            Console.WriteLine($"Canal inválido! Informe entre 1 e {CANAL_MAX}.");
        }
    }

    // Volume
    public void AumentarVolume()
    {
        if (!Estado) return;
        if (Volume < VOL_MAX) Volume++;
        else Console.WriteLine("Volume já está no máximo!");
        Console.WriteLine($"Volume atual: {Volume}");
    }

    public void DiminuirVolume()
    {
        if (!Estado) return;
        if (Volume > VOL_MIN) Volume--;
        else Console.WriteLine("Volume já está no mínimo!");
        Console.WriteLine($"Volume atual: {Volume}");
    }

    // Novo método: define o volume direto
    public void DefinirVolume(int valor)
    {
        if (!Estado) return;

        if (valor < VOL_MIN) Volume = VOL_MIN;
        else if (valor > VOL_MAX) Volume = VOL_MAX;
        else Volume = valor;

        Console.WriteLine($"Volume ajustado para: {Volume}");
    }

    public void AtivarMute()
    {
        if (!Estado) return;
        _mute = !_mute;
        Console.WriteLine(_mute ? "TV em modo mudo." : $"Mudo desativado. Volume: {Volume}");
    }
}
