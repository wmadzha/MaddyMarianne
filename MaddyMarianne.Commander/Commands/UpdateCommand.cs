using MaddyMarianne.Commander.Models;
using MaddyMarianne.Commander.Enums;
using MaddyMarianne.Commander.Builder;

namespace MaddyMarianne.Commander.Commands
{
    public static class UpdateCommand
    {
        public static CommandInput Generate(string messages)
        {
            return new CommandInput()
            {
                Command = CommandTypes.Update,
                CommandName = CommandNames.Update,
                Inputs = InputBuilder.ToInputs(messages),
            };
        }
    }
}
