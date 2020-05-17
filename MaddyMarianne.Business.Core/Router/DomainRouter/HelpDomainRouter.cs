using MaddyMarianne.Business.Core.DomainA.Processor;
using MaddyMarianne.Commander.Builders;
using MaddyMarianne.Commander.Models;
namespace MaddyMarianne.Business.Core.Router
{
    public partial class DomainRouter
    {
        public static CommandResult HelpCommand(ICommandInput cmd)
        {
            if(cmd.Inputs.Count == 0)
            {
                return ResultBuilder.Build(cmd, "Unable To Process Help Command : Please include <domainname> that you would like to request help about", false, null);
            }
            switch (cmd.Inputs["message_1"])
            {
                case "DomainA":
                    return new HelpDomainAProcessor(cmd).Process();
                default:
                    return ResultBuilder.Build(cmd, "Unable To Process Command", false, null);
            }
        }
    }
}
