using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IntergalacticTravel.Exceptions;

namespace IntergalacticTravel.Tests
{
    [TestClass]
    public class UnitsFactoryTests
    {
        [TestMethod]
        public void GetUnit_PassValidCorrespondingCommand_ShuldReturnNewProcyon()
        {
            var command = "create unit Procyon Gosho 1";
            var unitsFactory = new UnitsFactory();

            var unitToTest = unitsFactory.GetUnit(command);

            Assert.IsInstanceOfType(unitToTest, typeof(Procyon));
        }

        [TestMethod]
        public void GetUnit_PassValidCorrespondingCommand_ShuldReturnNewLuyten()
        {
            var command = "create unit Luyten Gosho 1";
            var unitsFactory = new UnitsFactory();

            var unitToTest = unitsFactory.GetUnit(command);

            Assert.IsInstanceOfType(unitToTest, typeof(Luyten));
        }

        [TestMethod]
        public void GetUnit_PassValidCorrespondingCommand_ShuldReturnNewLacaille()
        {
            var command = "create unit Lacaille Gosho 1";
            var unitsFactory = new UnitsFactory();

            var unitToTest = unitsFactory.GetUnit(command);

            Assert.IsInstanceOfType(unitToTest, typeof(Lacaille));
        }

        [TestMethod]
        [DataRow("invalid command")]
        [DataRow("create unit Pastet Gosho 1")]
        public void GetUnit_PassInvalidFormatCommand_ShouldThrowInvalidUnitCreationCommandException(string invalidCommand)
        {
            var unitsFactory = new UnitsFactory();

            Assert.ThrowsException<InvalidUnitCreationCommandException>(() => unitsFactory.GetUnit(invalidCommand));
        }
    }
}
