using MaddyMarianne.Commander.Enums;
using MaddyMarianne.Commander.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaddyMarianne.Commander.Commands
{
    public static class DeleteCommand
    {
        public static CommandInput Generate(string messages)
        {
            return new CommandInput()
            {
                Command = CommandTypes.Delete,
                CommandName = "Delete",
                Inputs = new Dictionary<string, string>()
                 {
                     { "mesage" , messages }
                 }
            };
        }
    }
}
