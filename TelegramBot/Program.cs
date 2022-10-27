
using TelegramBot.Core;

namespace TelegramBot
{
    internal class Program
    {


        static async Task Main(string[] args)
        {
            BotWorker botWorker = new BotWorker(); 
            botWorker.Start();
            Console.ReadLine();
        }
        
    }
}