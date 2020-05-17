using MaddyMarianne.Commander.Builders;
using MaddyMarianne.Commander.Models;
using MaddyMarianne.DataAccess.DomainA;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaddyMarianne.Business.Core.DomainA.Processor
{
    public class ViewDomainAProcessor : CommandInput
    {
        private DomainAEngine _Engine { get; set; }
        public ViewDomainAProcessor(ICommandInput cmd)
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
            var result = _Engine.GetAll();
          
            return  ResultBuilder.Build(
                        this,
                        "Successfully Fetched DomainA Data",
                        true,
                        result);
        }
    }
}
