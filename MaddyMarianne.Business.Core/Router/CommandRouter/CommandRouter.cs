using MaddyMarianne.Commander.Builders;
using MaddyMarianne.Commander.Enums;
using MaddyMarianne.Commander.Models;

namespace MaddyMarianne.Business.Core.Router
{
    public class CommandRouter
    {
        public CommandResult ProcessCommand(string commands)
        {
            ICommandInput cmd = CommandBuilder.GetCommandInput(commands);
            if (cmd.CommandName == CommandNames.Add)
                return DomainRouter.AddCommand(cmd);
            if (cmd.CommandName == CommandNames.Delete)
                return DomainRouter.DeleteCommand(cmd);
            if (cmd.CommandName == CommandNames.View)
                return DomainRouter.GetCommand(cmd);
            if (cmd.CommandName == CommandNames.Update)
                return DomainRouter.UpdateCommand(cmd);
            if (cmd.CommandName == CommandNames.Help)
                return DomainRouter.HelpCommand(cmd);
            else return ResultBuilder.Build(cmd,"Unable To Find Command",false,null);
        }
    }

  
}
