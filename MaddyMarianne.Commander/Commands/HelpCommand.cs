using MaddyMarianne.Commander.Enums;
using MaddyMarianne.Commander.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaddyMarianne.Commander.Commands
{

    public static class HelpCommand
    {
        public static CommandInput Generate(string messages)
        {
            return new CommandInput()
            {
                Command = CommandTypes.Help,
                CommandName = "Help",
                Inputs = new Dictionary<string, string>()
                {
                    { "domain", messages }
                },
            };
        }
    }
}
