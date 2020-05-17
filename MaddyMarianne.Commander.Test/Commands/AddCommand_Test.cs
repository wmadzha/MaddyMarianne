using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaddyMarianne.Commander.Commands;

namespace MaddyMarianne.Commander.Test.Commands
{
    [TestClass]
    public class AddCommand_Test
    {
        [TestMethod]
        public void Add_Command_Instantiation_Should_Return_Appropriate_Value()
        {
            var cmd = AddCommand.Generate("app -add SampleJsonObject");
            Assert.IsTrue(cmd.CommandName == "Add");
            Assert.IsTrue(cmd.Command == "-add");
            Assert.IsTrue(cmd.Inputs.ContainsKey("message_1"));
            Assert.IsTrue(cmd.Inputs["message_1"] == "SampleJsonObject");
        }
    }
}
