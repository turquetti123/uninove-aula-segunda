namespace app.Messages
{
    public class VideoMessage : Message
    {
        public string Arquivo { get; set; }
        public string Formato { get; set; }
        public int Duracao { get; set; }

        public VideoMessage(string texto, string arquivo, string formato, int duracao)
            : base(texto)
        {
            Arquivo = arquivo;
            Formato = formato;
            Duracao = duracao;
        }

        public override string Format()
        {
            return $"[VIDEO] {Texto} - Arquivo: {Arquivo} ({Formato}) - Duração: {Duracao}s";
        }
    }
}
