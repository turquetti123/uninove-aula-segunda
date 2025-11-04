using app.Messages;

namespace app.Channels
{
    public abstract class Channel
    {
        public string Destinatario { get; set; }

        public Channel(string destinatario)
        {
            Destinatario = destinatario;
        }

        public abstract void Send(Message msg);
    }
}
