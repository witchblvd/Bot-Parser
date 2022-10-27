using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;
using Parser;
using Parser.Core;
using Parser.Core.Sites.shikimori;

namespace TelegramBot.Core.Commands;

public class Top100Command : Command
{
    public override string Name => "/top100";

    public override async void Execute(Message message, ITelegramBotClient client)
    {
        var chatId = message.Chat.Id;
        ParserWorker parserWorker = new ParserWorker(new ShikimoriParser(), new ShikimoriSettings(0,0));
        var list = await parserWorker.Start();

        StringBuilder listAnime = new StringBuilder();

        for (int i = 0; i <= 100; i++)
        {
            listAnime.Append($"\n {i}. \t   {list[i]}");
        }
      

        await client.SendTextMessageAsync(chatId, listAnime.ToString());
    }

    

}