using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntergalacticTravel.Tests
{
    [TestClass]
    public class ResourcesFactoryTests
    {
        [TestMethod]
        [DataRow("create resources gold(20) silver(30) bronze(40)")]
        [DataRow("create resources gold(20) bronze(40) silver(30)")]
        [DataRow("create resources silver(30) bronze(40) gold(20)")]
        [DataRow("create resources silver(30) gold(20) bronze(40)")]
        [DataRow("create resources bronze(40) gold(20) silver(30)")]
        [DataRow("create resources bronze(40) silver(30) gold(20)")]
        public void GetResources_PassInputStringInCorrectFormatWithAnyOrderOfParameters_ShouldReturnNewlyCreatedResourcesObjectWithCorrectlySetUpProperties(string command)
        {
            uint expectedGold = 20;
            uint expectedSilver = 30;
            uint expectedBronze = 40;
            var resourcesFactory = new ResourcesFactory();

            var resourcesToTest = resourcesFactory.GetResources(command);

            Assert.AreEqual(expectedGold, resourcesToTest.GoldCoins, "incorrect gold");
            Assert.AreEqual(expectedSilver, resourcesToTest.SilverCoins, "incorrect silver");
            Assert.AreEqual(expectedBronze, resourcesToTest.BronzeCoins, "incorrect bronze");
        }

        [TestMethod]
        [DataRow("create resources x y z")]
        [DataRow("tansta resources a b")]
        [DataRow("absolutelyRandomStringThatMustNotBeAValidCommand")]
        public void GetResources_PassInvallidCommand_ShouldThrowInvalidOperationExceptionWichContainsTheStringCommand(string invalidCommand)
        {
            var resourcesFactory = new ResourcesFactory();

            Assert.IsTrue(Assert.ThrowsException<InvalidOperationException>(() => resourcesFactory.GetResources(invalidCommand)).Message.Contains("command"), "message dosnot contains the string command");
        }

        [TestMethod]
        [DataRow("create resources silver(10) gold(97853252356623523532) bronze(20)")]
        [DataRow("create resources silver(555555555555555555555555555555555) gold(97853252356623523532999999999) bronze(20)")]
        [DataRow("create resources silver(10) gold(20) bronze(4444444444444444444444444444444444444)")]
        public void GetResources_PassCommandInCorrectFormatWithAnyParameterLargerThanUintMaxValue_ShoulThrowOverflowException(string invalidCommand)
        {
            var resourcesFactory = new ResourcesFactory();

            Assert.ThrowsException<OverflowException>(() => resourcesFactory.GetResources(invalidCommand));
        }
    }
}
