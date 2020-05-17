using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaddyMarianne.Commander.Models;
using MediatR;
namespace MaddyMarianne.Web.AspNetCore.Api.MediatR
{
    public class CommandRequest: IRequest<CommandResult>
    {
        public string Command { get; set; }
        public CommandRequest(string command)
        {
            Command = command;
        }
    }
}
