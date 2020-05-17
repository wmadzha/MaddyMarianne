using MaddyMarianne.Commander.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaddyMarianne.Commander.Test.Builder
{
    [TestClass]
    public class Builder_Test
    {
        [TestMethod]
        public void Should_Return_Add_Command_Input_Object()
        {
            var cmd = CommandBuilder.GetCommandInput("applicationName -add new test object");
            Assert.IsTrue(cmd.CommandName == "Add");
        }
      
        [TestMethod]
        public void Should_Return_Delete_Command_Input_Object()
        {
            var cmd = CommandBuilder.GetCommandInput("applicationName -delete new test object");
            Assert.IsTrue(cmd.CommandName == "Delete");
        }
        [TestMethod]
        public void Should_Return_View_Command_Input_Object()
        {
            var cmd = CommandBuilder.GetCommandInput("applicationName -view");
            Assert.IsTrue(cmd.CommandName == "View");
        }
        [TestMethod]
        public void Should_Return_Unknown_Command_Input_Object()
        {
            var cmd = CommandBuilder.GetCommandInput("anything for example hello world");
            Assert.IsTrue(cmd.CommandName == "Unknown");
        }
        [TestMethod]
        public void Should_Return_Help_Command_Input_Object()
        {
            var cmd = CommandBuilder.GetCommandInput("applicationName -help domain");
            Assert.IsTrue(cmd.CommandName == "Help");
        }
    }
}
