using System;
using System.Collections.Generic;
namespace MaddyMarianne.Commander.Models
{
    public class CommandInput : ICommandInput
    {
        public Guid CommandTransctionId { get; set; }
        public string CommandName { get; set; }
        public string Command { get; set; }
        public Dictionary<string,string> Inputs { get; set; }
        public CommandInput()
        {
            Inputs = new Dictionary<string, string>();
            CommandTransctionId = Guid.NewGuid();
        }

        public virtual CommandResult Process()
        {
            throw new NotImplementedException();
        }
    }

    public interface ICommandInput
    {
        Guid CommandTransctionId { get; set; }
        string CommandName { get; set; }
        string Command { get; set; }
        Dictionary<string, string> Inputs { get; set; }
        CommandResult Process();

    }
}
