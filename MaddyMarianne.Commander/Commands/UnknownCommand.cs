using MaddyMarianne.Commander.Enums;
using MaddyMarianne.Commander.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaddyMarianne.Commander.Commands
{
    public static class UnknownCommand
    {
        public static CommandInput Generate(string messages)
        {
            return new CommandInput()
            {
                Command = CommandTypes.NotValid,
                CommandName = "Unknown",
                Inputs = new Dictionary<string, string>()
                {
                    { "message", messages }
                },
            };
        }
    }
}
