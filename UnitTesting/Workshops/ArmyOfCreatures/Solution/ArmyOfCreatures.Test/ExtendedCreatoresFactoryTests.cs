using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArmyOfCreatures.Extended;
using ArmyOfCreatures.Extended.Creatures;

namespace ArmyOfCreatures.Test
{
    [TestClass]
    public class ExtendedCreatoresFactoryTests
    {
        [DataTestMethod]
        [DataRow("AncientBehemoth", typeof(AncientBehemoth))]
        [DataRow("CyclopsKing", typeof(CyclopsKing))]
        [DataRow("Goblin", typeof(Goblin))]
        [DataRow("Griffin", typeof(Griffin))]
        [DataRow("WolfRaider", typeof(WolfRaider))]
        public void CreateCretures_PassingValidStringName_ShouldReturnCorrespondingInstance(string creatureName, Type expectedCretureType)
        {
            var extendedCreaturesFactory = new ExtendedCreaturesFactory();

            var creature = extendedCreaturesFactory.CreateCreature(creatureName);

            Assert.IsInstanceOfType(creature, expectedCretureType);

        }

        [TestMethod]
        public void CreateCreature_PassingInvalidStringName_ShouldThrow()
        {
            var invalidStringName = "asjdbasbgasd";

            var extendedCreaturesFactory = new ExtendedCreaturesFactory();

            var ex = Assert.ThrowsException<ArgumentException>(() => extendedCreaturesFactory.CreateCreature(invalidStringName));

            Assert.IsTrue(ex.Message.Contains("Invalid creature type"), "Invalid exception message!");
        }
    }
}
