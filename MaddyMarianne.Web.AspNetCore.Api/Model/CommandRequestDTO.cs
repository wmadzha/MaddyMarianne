using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security;

namespace MaddyMarianne.Web.AspNetCore.Api.Model
{
    public class CommandRequestDTO
    {
        public string message { get; set; }
        public string clientKey { get; set; }
      
    }
}
