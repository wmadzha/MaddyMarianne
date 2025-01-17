﻿using MaddyMarianne.Commander.Enums;
using MaddyMarianne.Commander.Models;
using MaddyMarianne.Commander.Builder;

namespace MaddyMarianne.Commander.Commands
{
    public static class UnknownCommand
    {
        public static CommandInput Generate(string messages)
        {
            return new CommandInput()
            {
                Command = CommandTypes.NotValid,
                CommandName = CommandNames.Unknown,
                Inputs = InputBuilder.ToInputs(messages),
            };
        }
    }
}
