using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cosmetics.Engine;
using System.Collections.Generic;

namespace Cosmetics.Tests
{
    [TestClass]
    public class EngineCommandTests
    {
        [TestMethod]
        [DataRow("Name")]
        [DataRow("Name 1 2")]
        public void Parse_PassValidInputString_ShuoldReturnNewCommand(string name)
        {
            var command = Command.Parse(name);

            Assert.IsInstanceOfType(command, typeof(Command));
        }

        [TestMethod]
        [DataRow("Name1")]
        [DataRow("Name2 1 2")]
        [DataRow("Name3 1 2 3")]
        [DataRow("Name4 1 2 3 test")]
        public void Parse_PassValidInputString_ShuoldReturnNewCommandWithCorrectValuesForNameAndParameters(string str)
        {
            var command = Command.Parse(str);
            var allParameters = str.Split(' ');
            var name = allParameters[0];
            List<string> parameters = allParameters.Length > 1 ? allParameters.Skip(1).ToList() : null;

            Assert.AreEqual(name, command.Name);

            if (parameters != null)
            {
                Assert.IsTrue(parameters.SequenceEqual(command.Parameters),"Parameters not equal");
            }
        }

        [TestMethod]
        public void Parse_PassNullOrEmptyNameInInputString_ShouldThrowArgumentNullExceptionWithMessageContainsTheStringName()
        {
            var invalidInput = " ForMale Cool";


            Assert.IsTrue(Assert.ThrowsException<ArgumentNullException>(() => Command.Parse(invalidInput)).Message.Contains("Name"));
        
    }

        [TestMethod]
        public void Parse_PassNullOrEmptyParamsInInputString_ShouldThrowArgumentNullExceptionWithMessageContainsTheStringName()
        {
            var invalidInput = "AddToCategory ";


            Assert.IsTrue(Assert.ThrowsException<ArgumentNullException>(() => Command.Parse(invalidInput)).Message.Contains("List"));

        }


    }
}
