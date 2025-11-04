namespace app.Messages
{
    public abstract class Message
    {
        public string Texto { get; set; }

        public Message(string texto)
        {
            Texto = texto;
        }

        public abstract string Format();
    }
}
