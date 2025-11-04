namespace app.Messages
{
    public class PhotoMessage : Message
    {
        public string Arquivo { get; set; }
        public string Formato { get; set; }

        public PhotoMessage(string texto, string arquivo, string formato) : base(texto)
        {
            Arquivo = arquivo;
            Formato = formato;
        }

        public override string Format()
        {
            return $"[FOTO] {Texto} - Arquivo: {Arquivo} ({Formato})";
        }
    }
}
