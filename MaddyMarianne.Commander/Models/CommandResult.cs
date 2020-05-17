using System;
using System.Collections.Generic;
using System.Text;

namespace MaddyMarianne.Commander.Models
{
    public class CommandResult
    {
        public Guid CommandTransactionId { get; set; }
        public string CommandName { get; set; }
        public string Command { get; set; }
        public Guid CommandResultId { get; set; }
        public string Message { get; set; }
        public bool IsContainException { get; set; }
        public bool IsSuccess { get; set; }
        public Object Result { get; set; }
    }
}
