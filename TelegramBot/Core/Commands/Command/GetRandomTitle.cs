using System.Text;
using Parser.Core;
using Parser.Core.Sites.shikimori;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.Core.Commands;

public class GetRandomTitle : Command
{
    public override string Name => "/randomtitle";
    public override async  void Execute(Message message, ITelegramBotClient client)
    {
        var chatId = message.Chat.Id;
        ParserWorker parserWorker = new ParserWorker(new ShikimoriParser(), new ShikimoriSettings(0,0));
        var list = await parserWorker.Start();
        Random rnd = new Random();
      
        var randomTitle = list[rnd.Next(0,100)];
        
        await client.SendTextMessageAsync(chatId, randomTitle);
    }
}