using MaddyMarianne.Commander.Commands;
using MaddyMarianne.Commander.Enums;
using MaddyMarianne.Commander.Models;

namespace MaddyMarianne.Commander.Builders
{
    public static class CommandBuilder
    {
        public static CommandInput GetCommandInput(string message)
        {
            return GetType(message.Split(' '),message);
        }
        public static CommandInput GetType(string[] commands , string message)
        {
            if(commands.Length <= 1)
                return UnknownCommand.Generate(message);
            switch (commands[1])
             {
                case CommandTypes.Add:
                    return AddCommand.Generate(message);
                case CommandTypes.View:
                    return ViewCommand.Generate(message);
                case CommandTypes.Delete:
                    return DeleteCommand.Generate(message);
                case CommandTypes.Help:
                    return HelpCommand.Generate(message);
                case CommandTypes.Update:
                    return UpdateCommand.Generate(message);
                default:
                    return UnknownCommand.Generate(message);
             }
        }
    }
}
