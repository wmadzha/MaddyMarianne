using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaddyMarianne.Commander.Commands;
namespace MaddyMarianne.Commander.Test.Commands
{
    [TestClass]
    public class UnknownCommand_Test
    {
        [TestMethod]
        public void Unknown_Command_Instantiation_Should_Return_Appropriate_Value()
        {
            var cmd = UnknownCommand.Generate("app some jibberish command form user");
            Assert.IsTrue(cmd.CommandName == "Unknown");
            Assert.IsTrue(cmd.Command == "notValid");
            Assert.IsTrue(cmd.Inputs.ContainsKey("message_1"));
            Assert.IsTrue(cmd.Inputs["message_1"] == "jibberish");
            Assert.IsTrue(cmd.Inputs.ContainsKey("message_2"));
            Assert.IsTrue(cmd.Inputs["message_2"] == "command");
            Assert.IsTrue(cmd.Inputs.ContainsKey("message_3"));
            Assert.IsTrue(cmd.Inputs["message_3"] == "form");
            Assert.IsTrue(cmd.Inputs.ContainsKey("message_4"));
            Assert.IsTrue(cmd.Inputs["message_4"] == "user");
        }
    }
}
