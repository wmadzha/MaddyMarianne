using MaddyMarianne.Business.Core.Router;
using MaddyMarianne.Commander.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MaddyMarianne.Web.AspNetCore.Api.MediatR
{
    public class CommandHandler : IRequestHandler<CommandRequest, CommandResult>
    {
        public CommandHandler()
        {
            // Just In Case We Have Dependency Injection
        }
        public  Task<CommandResult> Handle(CommandRequest request, CancellationToken cancellationToken)
        {
            var result = new CommandRouter().ProcessCommand(request.Command);
            return Task.FromResult(result);
        }
    }
}
