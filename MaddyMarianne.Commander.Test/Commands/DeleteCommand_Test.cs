using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaddyMarianne.Commander.Commands;
namespace MaddyMarianne.Commander.Test.Commands
{
    [TestClass]
    public class DeleteCommand_Test
    {
        [TestMethod]
        public void Delete_Command_Instantiation_Should_Return_Appropriate_Value()
        {
            var cmd = DeleteCommand.Generate("app -delete SampleDatabasePrimaryKeyId");
            Assert.IsTrue(cmd.CommandName == "Delete");
            Assert.IsTrue(cmd.Command == "-delete");
            Assert.IsTrue(cmd.Inputs.ContainsKey("message_1"));
            Assert.IsTrue(cmd.Inputs["message_1"] == "SampleDatabasePrimaryKeyId");
        }
    }
}
