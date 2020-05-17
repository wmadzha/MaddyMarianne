using MaddyMarianne.Commander.Builders;
using MaddyMarianne.Commander.Models;
using MaddyMarianne.DataAccess.DomainA;
using System.Collections.Generic;

namespace MaddyMarianne.Business.Core.DomainA.Processor
{
    public class HelpDomainAProcessor : CommandInput
    {
        private DomainAEngine _Engine { get; set; }
        public HelpDomainAProcessor(ICommandInput cmd)
        {
            this.CommandTransctionId = cmd.CommandTransctionId;
            this.CommandName = cmd.CommandName;
            this.Command = cmd.Command;
            this.Inputs = cmd.Inputs;
            // if We Have DI then it will be better
            _Engine = new DomainAEngine();
        }
        public override CommandResult Process()
        {
            List<string> DomainAHelpList = new List<string>();
            DomainAHelpList.Add("-add <jsonobject> : To Add Object");
            DomainAHelpList.Add("-delete <primarykeyid> : To Delete Object");
            DomainAHelpList.Add("-update <jsonObject> : To Update Specific Object");
            DomainAHelpList.Add("-view DomainA : To View All Object in Domain A");
                return ResultBuilder.Build(
                            this,
                            "Successfully Fetch DomainA Helps",
                            true,
                            DomainAHelpList);
        }
    }
}
