using MaddyMarianne.Commander.Builder;
using MaddyMarianne.Commander.Enums;
using MaddyMarianne.Commander.Models;
namespace MaddyMarianne.Commander.Commands
{
    public static class DeleteCommand
    {
        public static CommandInput Generate(string messages)
        {
            return new CommandInput()
            {
                Command = CommandTypes.Delete,
                CommandName = "Delete",
                Inputs = InputBuilder.ToInputs(messages),
            };
        }
    }
}
