using MaddyMarianne.Commander.Builders;
using MaddyMarianne.Commander.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MaddyMarianne.Web.AspNetCore.Api.MediatR.KeyValidations
{

    public class KeyValidationHandler : IRequestHandler<KeyValidationRequest, CommandResult>
    {
        private readonly IMediator _mdtr;
        public KeyValidationHandler(IMediator mediator)
        {
            // Just In Case We Have Dependency Injection
            _mdtr = mediator;
        }

        public Task<CommandResult> Handle(KeyValidationRequest request, CancellationToken cancellationToken)
        {
            if (Validate(request.Key))
                return _mdtr.Send(new CommandRequest(request.Command));
            else
                return Task.FromResult(new CommandResult()
                {
                    Message = "Key Is Not Valid",
                });
        }

        private bool Validate(string key)
        {
            // Do some client key validation
            return true;
        }
    }
}
