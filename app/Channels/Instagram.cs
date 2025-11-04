using System;
using app.Messages;

namespace app.Channels
{
    public class Instagram : Channel
    {
        public Instagram(string usuario) : base(usuario) {}

        public override void Send(Message msg)
        {
            Console.WriteLine($"Enviando via Instagram para @{Destinatario}");
            Console.WriteLine(msg.Format());
        }
    }
}
