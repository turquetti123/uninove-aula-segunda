using System;

namespace app.Messages
{
    public class TextMessage : Message
    {
        public DateTime DataEnvio { get; set; }

        public TextMessage(string texto) : base(texto)
        {
            DataEnvio = DateTime.Now;
        }

        public override string Format()
        {
            return $"[TEXTO] {Texto} - Enviado em {DataEnvio}";
        }
    }
}
