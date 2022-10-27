using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.Core.Commands;

public class StartCommand : Command
{
    public override string Name => "/start";

    public override void Execute(Message message, ITelegramBotClient client)
    {
        var chatId = message.Chat.Id;

        client.SendTextMessageAsync(chatId, 
            "Привет, я рад, что этот бот кому-то пригодился. Выбери из меню нужную функцию. " +
            "\n Функции: \n /top100 - Список топ-100 аниме по популярности \n /randomtitle - Случайное аниме");
    }
}