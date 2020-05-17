using MaddyMarianne.Commander.Enums;
using MaddyMarianne.Commander.Models;
using MaddyMarianne.Commander.Builder;

namespace MaddyMarianne.Commander.Commands
{

    public static class HelpCommand
    {
        public static CommandInput Generate(string messages)
        {
            return new CommandInput()
            {
                Command = CommandTypes.Help,
                CommandName = "Help",
                Inputs = InputBuilder.ToInputs(messages),
            };
        }
    }
}
