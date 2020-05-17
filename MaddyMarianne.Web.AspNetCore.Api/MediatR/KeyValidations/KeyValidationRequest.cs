using MaddyMarianne.Commander.Models;
using MaddyMarianne.Web.AspNetCore.Api.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaddyMarianne.Web.AspNetCore.Api.MediatR.KeyValidations
{
    public class KeyValidationRequest : IRequest<CommandResult>
    {
        public string Command { get; set; }
        public string Key { get; set; }
        public KeyValidationRequest(CommandRequestDTO dto)
        {
            Command = dto.message;
            Key = dto.clientKey;
        }
    }

}
