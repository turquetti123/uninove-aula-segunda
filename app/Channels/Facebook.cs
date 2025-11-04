using System;
using app.Messages;

namespace app.Channels
{
    public class Facebook : Channel
    {
        public Facebook(string usuario) : base(usuario) {}

        public override void Send(Message msg)
        {
            Console.WriteLine($"Enviando via Facebook para @{Destinatario}");
            Console.WriteLine(msg.Format());
        }
    }
}
