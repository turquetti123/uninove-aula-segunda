using System;
using app.Messages;
using app.Channels;

namespace app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message msg1 = new TextMessage("Olá mundo!");
            Message msg2 = new PhotoMessage("Minha foto nova", "foto.png", "png");
            Message msg3 = new VideoMessage("Vídeo top", "video.mp4", "mp4", 20);

            Channel wpp = new WhatsApp("+55999999999");
            Channel insta = new Instagram("ceciturque");
            Channel fb = new Facebook("ceci.moraes");
            Channel tgUser = new TelegramUser("ceci");
            Channel tgPhone = new TelegramPhone("+551199999999");

            wpp.Send(msg1);
            insta.Send(msg2);
            fb.Send(msg1);
            tgUser.Send(msg3);
            tgPhone.Send(msg1);
        }
    }
}
