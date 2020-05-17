using MaddyMarianne.Commander.Builders;
using MaddyMarianne.Commander.Models;
using MaddyMarianne.DataAccess.DomainA;

namespace MaddyMarianne.Business.Core.DomainA.Processor
{

    public class AddDomainAProcessor : CommandInput , ICommandInput
    {
        private DomainAEngine _Engine { get; set; }
        public AddDomainAProcessor(ICommandInput cmd)
        {
            this.CommandTransctionId = cmd.CommandTransctionId;
            this.CommandName = cmd.CommandName;
            this.Command = cmd.Command;
            this.Inputs = cmd.Inputs;
            // if We Have DI then it will be better Since at MediatR we can reduce Dependency Injection
            _Engine = new DomainAEngine();
        }
        public override CommandResult Process()
        {
            //  More Buisness Operation 

            // Sample Data Store CRUD
            var result = _Engine.AddDomainAObject(this.Inputs["message_1"]);

            return ResultBuilder.Build(
                        this,
                        "Successfully Add DomainA Data",
                        true,
                        result);
        }
    }
}
