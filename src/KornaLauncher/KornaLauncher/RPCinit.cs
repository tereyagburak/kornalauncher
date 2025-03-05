using System;
using DiscordRPC;

namespace KornaLauncher
{
    class RPCinit
    {
        public DiscordRpcClient client; // Sınıf genelinde geçerli `client`

        public RPCinit()
        {
            Initialize();
        }

        private void Initialize()
        {
            // `client` artık sınıf genelindeki değişkene atanıyor
            client = new DiscordRpcClient("id");

            client.Initialize();

            client.SetPresence(new RichPresence()
            {
                Details = "Korncraft, by michaelsoft",
                State = Properties.Settings.Default.kullaniciAdi,
                Assets = new Assets()
                {
                    LargeImageKey = "large_image",
                    LargeImageText = "videoliq.com.tr/korna",
                    SmallImageKey = "micro",
                    SmallImageText = "Michaelsoft Games"
                }
            });

            Console.WriteLine("Discord RPC aktif!");
        }
    }
}
