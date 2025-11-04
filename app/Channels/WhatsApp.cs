using System;
using app.Messages;

namespace app.Channels
{
    public class WhatsApp : Channel
    {
        public WhatsApp(string numero) : base(numero) {}

        public override void Send(Message msg)
        {
            Console.WriteLine($"Enviando via WhatsApp para {Destinatario}");
            Console.WriteLine(msg.Format());
        }
    }
}
