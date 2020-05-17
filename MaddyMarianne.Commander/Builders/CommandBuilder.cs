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
             switch(commands[1])
             {
                case "-add":
                    return AddCommand.Generate(message);
                case "-view":
                    return ViewCommand.Generate(message);
                case "-delete":
                    return DeleteCommand.Generate(message);
                case "-help":
                    return HelpCommand.Generate(message);
                default:
                    return UnknownCommand.Generate(message);
             }
        }
    }
}
