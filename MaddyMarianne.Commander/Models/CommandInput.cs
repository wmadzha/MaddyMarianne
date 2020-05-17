﻿using System.Collections.Generic;
namespace MaddyMarianne.Commander.Models
{
    public sealed class CommandInput
    {
        public string CommandName { get; set; }
        public string Command { get; set; }
        public Dictionary<string,string> Inputs { get; set; }
        public CommandInput()
        {
            Inputs = new Dictionary<string, string>();
        }
    }
}
