using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
using TelegramBot.Core.Commands;

namespace TelegramBot.Core;

public class BotWorker
{
    private static TelegramBotClient _botClient;
 
    private static List<Command> commandsList;

  
    public BotWorker()
    {
        _botClient = new TelegramBotClient($"{SettingsBot.Key}");
        commandsList = new List<Command>();
    }

    public void Start()
    {
        Worker();
    }
   
    private async Task Worker()
    {
        _botClient.StartReceiving(Update, Error);
        
    }

    private Task Error(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
    {
        throw new NotImplementedException();
    }

    private async Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
    {
        commandsList = Command.SetListCommands();

        var message  = update.Message;
        
            foreach (var command in commandsList)
            {
                if (command.Equals(message.Text))
                {
                    command.Execute(message, botClient);
                    break;
                }
            }
        
            
    }

    private async Task updateHandler(ITelegramBotClient arg1, Update arg2, CancellationToken arg3)
    {
        
    }
}