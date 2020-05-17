using MaddyMarianne.Commander.Builders;
using MaddyMarianne.Commander.Models;
using MaddyMarianne.DataAccess.DomainA;

namespace MaddyMarianne.Business.Core.DomainA.Processor
{

    public class UpdateDomainAProcessor : CommandInput
    {
        private DomainAEngine _Engine { get; set; }
        public UpdateDomainAProcessor(ICommandInput cmd)
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
            //  More Buisness Operation 

            // Sample Data Store CRUD
            var result = _Engine.UpdateDomainObject(this.Inputs["message_1"]);
            if (result)
                return ResultBuilder.Build(
                            this,
                            "Successfully Update DomainA Data",
                            true,
                            result);
            else
                return ResultBuilder.Build(this,"Unable To Update DomainA Data",  false, null);
        }
    }
}
