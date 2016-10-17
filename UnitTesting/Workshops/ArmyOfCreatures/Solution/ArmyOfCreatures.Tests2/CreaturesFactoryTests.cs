using System;

using ArmyOfCreatures.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArmyOfCreatures.Extended;

namespace ArmyOfCreatures.Tests2
{
    [TestClass]
    public class CreaturesFactoryTests
    {
        [TestMethod]
        [DataRow("Angel")]
        [DataRow("Behemoth")]
        [DataRow("Devil")]
        public void CreateCreature_PassedValidName_ShouldReturnExpectedType(string name)
        {
            var factory = new ExtendedCreaturesFactory();

            var creature = factory.CreateCreature(name);

            Assert.AreEqual(name, creature.GetType().Name);
        }

        [TestMethod]
        [DataRow("asdflnkhjklfnjklasffrasdfasfjkjksdfbjksdbs")]
        [DataRow("qwqjklq,web f cvkjgkebfkqwefbb qwehjbfkqwehbebfkqwe")]
        [DataRow("")]
        [DataRow(null)]
        public void CreatureFactory_PassedInvalidName_ShouldThroewArgumentExceptionWithExpectedMessage(string invalidNmae)
        {
            var factory = new ExtendedCreaturesFactory();

            var ex = Assert.ThrowsException<ArgumentException>(() => factory.CreateCreature(invalidNmae));


            Assert.AreEqual($"Invalid creature type \"{invalidNmae}\"!", ex.Message);
        }
    }
}
