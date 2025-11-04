using System;
using app.Messages;

namespace app.Channels
{
    public class TelegramUser : Channel
    {
        public TelegramUser(string usuario) : base(usuario) {}

        public override void Send(Message msg)
        {
            Console.WriteLine($"Enviando via Telegram (usuário) para @{Destinatario}");
            Console.WriteLine(msg.Format());
        }
    }
}
