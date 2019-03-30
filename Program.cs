using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace TestTelegramBot
{
    static class Progёram
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient("835831458:AAGqMWSC1nUHcwWn4wVxqrsEBbyFJ7vvtE8");
        static void Main(string[] args)
        {
            Bot.OnMessage += Bot_OnMessage;

            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e.Message.Type == MessageType.Text)
            {
                Console.WriteLine(e.Message.Text);
            }
        }
    }
}
