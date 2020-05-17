using MaddyMarianne.Commander.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MaddyMarianne.Commander.Enums;

namespace MaddyMarianne.Commander.Commands
{
    public static class AddCommand
    {
        public static CommandInput Generate(string messages)
        {
            return new CommandInput()
            {
                Command = CommandTypes.Add,
                CommandName = "Add",
                 Inputs = new Dictionary<string, string>()
                 {
                     { "mesage" , messages }
                 }
            };
        }
    }
}
