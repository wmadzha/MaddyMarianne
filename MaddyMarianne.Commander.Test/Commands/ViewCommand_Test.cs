using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaddyMarianne.Commander.Commands;

namespace MaddyMarianne.Commander.Test.Commands
{
    [TestClass]
    public  class ViewCommand_Test
    {
        [TestMethod]
        public void View_Command_Instantiation_Should_Return_Appropriate_Value()
        {
            var cmd = ViewCommand.Generate("app -view somedomaintoview");
            Assert.IsTrue(cmd.CommandName == "View");
            Assert.IsTrue(cmd.Command == "-view");
            Assert.IsTrue(cmd.Inputs.ContainsKey("message_1"));
            Assert.IsTrue(cmd.Inputs["message_1"] == "somedomaintoview");
          
        }
    }
}
