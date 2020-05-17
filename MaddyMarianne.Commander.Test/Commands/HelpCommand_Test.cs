using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaddyMarianne.Commander.Commands;

namespace MaddyMarianne.Commander.Test.Commands
{
    [TestClass]
    public class HelpCommand_Test
    {
        [TestMethod]
        public void Help_Command_Instantiation_Should_Return_Appropriate_Value()
        {
            var cmd = HelpCommand.Generate("app -help SampleDomain");
            Assert.IsTrue(cmd.CommandName == "Help");
            Assert.IsTrue(cmd.Command == "-help");
            Assert.IsTrue(cmd.Inputs.ContainsKey("message_1"));
            Assert.IsTrue(cmd.Inputs["message_1"] == "SampleDomain");
        }
    }
}
