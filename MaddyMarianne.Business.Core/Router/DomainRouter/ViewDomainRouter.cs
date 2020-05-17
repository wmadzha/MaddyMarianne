using MaddyMarianne.Business.Core.DomainA.Processor;
using MaddyMarianne.Commander.Builders;
using MaddyMarianne.Commander.Models;
namespace MaddyMarianne.Business.Core.Router
{
    public partial class DomainRouter
    {
        public static CommandResult GetCommand(ICommandInput cmd)
        {
            switch (cmd.Inputs["message_1"])
            {
                case "DomainA":
                    return new ViewDomainAProcessor(cmd).Process();
                default:
                    return ResultBuilder.Build(cmd, "Unable To Process Command", false, null);
            }
        }
    }
}
