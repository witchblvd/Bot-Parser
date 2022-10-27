using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.Core.Commands;

public abstract class Command
{
    public abstract string Name { get; }

    public abstract void Execute(Message message, ITelegramBotClient client);

    public bool Equals(string command)
    {
        return command.Equals(this.Name);
    }

    public static List<Command> SetListCommands()
    {
        List<Command> list = new List<Command>();
        // Write here all bot commands
        list.Add(new StartCommand()); 
        list.Add(new Top100Command());
        list.Add(new GetRandomTitle());
     
     
     return list;
    }

}