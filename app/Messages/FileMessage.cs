namespace app.Messages
{
    public class FileMessage : Message
    {
        public string Arquivo { get; set; }
        public string Formato { get; set; }

        public FileMessage(string texto, string arquivo, string formato)
            : base(texto)
        {
            Arquivo = arquivo;
            Formato = formato;
        }

        public override string Format()
        {
            return $"[ARQUIVO] {Texto} - Arquivo: {Arquivo} ({Formato})";
        }
    }
}
