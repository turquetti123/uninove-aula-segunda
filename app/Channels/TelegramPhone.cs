using System;
using app.Messages;

namespace app.Channels
{
    public class TelegramPhone : Channel
    {
        public TelegramPhone(string numero) : base(numero) {}

        public override void Send(Message msg)
        {
            Console.WriteLine($"Enviando via Telegram (telefone) para {Destinatario}");
            Console.WriteLine(msg.Format());
        }
    }
}
