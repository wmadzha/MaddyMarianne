using MaddyMarianne.Commander.Models;
using MaddyMarianne.Commander.Enums;
using MaddyMarianne.Commander.Builder;

namespace MaddyMarianne.Commander.Commands
{
    public static class ViewCommand
    {
        public static CommandInput Generate(string messages)
        {
            return new CommandInput()
            {
                Command = CommandTypes.View,
                CommandName = CommandNames.View,
                Inputs = InputBuilder.ToInputs(messages),
            };
        }
    }
}
