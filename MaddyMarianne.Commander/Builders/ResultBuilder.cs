using MaddyMarianne.Commander.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaddyMarianne.Commander.Builders
{
    public static class ResultBuilder
    {
        public static CommandResult Build(ICommandInput input, bool isSuccess = true, Object objectResult = null)
        {
            return Build(input, string.Empty, isSuccess, objectResult);
        }
        public static CommandResult Build(ICommandInput input ,string message, bool isSuccess = true, Object objectResult = null)
        {
            return new CommandResult()
            {
                Command = input.Command,
                CommandName = input.CommandName,
                CommandResultId = Guid.NewGuid(),
                CommandTransactionId = input.CommandTransctionId,
                IsContainException = false,
                IsSuccess = isSuccess,
                Message = message,
                Result = objectResult
            };
        }
    }
}
