using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaddyMarianne.Business.Core.Router;
using MaddyMarianne.Web.AspNetCore.Api.MediatR;
using MaddyMarianne.Web.AspNetCore.Api.MediatR.KeyValidations;
using MaddyMarianne.Web.AspNetCore.Api.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaddyMarianne.Web.AspNetCore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandLineController : ControllerBase
    {
        private readonly IMediator _mdtr;
        public CommandLineController(IMediator mediator)
        {
            _mdtr = mediator;
        }
        [HttpGet]
        public   Task<IActionResult> Get()
        {
            return Task.FromResult((IActionResult)new OkObjectResult("Hello from CLI to MediatR"));
        }
        [HttpGet]
        [Route("getresult")]
        public async Task<IActionResult> GetResult([FromBody]CommandRequestDTO command)
        {
            var result = await _mdtr.Send(new KeyValidationRequest(command));
            return result != null ? (IActionResult) Ok(result) : BadRequest();
        }
    }
}