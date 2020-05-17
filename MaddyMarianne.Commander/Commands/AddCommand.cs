using MaddyMarianne.Commander.Models;
using MaddyMarianne.Commander.Enums;
using MaddyMarianne.Commander.Builder;

namespace MaddyMarianne.Commander.Commands
{
    public static class AddCommand
    {
        public static CommandInput Generate(string messages)
        {
            return new CommandInput()
            {
                Command = CommandTypes.Add,
                CommandName = CommandNames.Add,
                Inputs = InputBuilder.ToInputs(messages),
            };
        }
    }
}
