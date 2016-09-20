using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using IntergalacticTravel.Contracts;
using System.Collections.Generic;
using IntergalacticTravel.Exceptions;

namespace IntergalacticTravel.Tests
{
    [TestClass]
    public class TeleportStationTests
    {
        [TestMethod]
        public void Constructor_PassValidParameters_ShouldCreateTeleportStationWithCorrectlySetUpOfTheProvitedFieldsOwnerGalacticMapLocation()
        {
            //Arrange
            var mockedOwner = new Mock<IBusinessOwner>();

            var mockedPath = new Mock<IPath>();
            mockedPath.SetupGet<string>(p => p.TargetLocation.Planet.Name).Returns("SomeDiferentPlanetName");
            mockedPath.SetupGet<string>(p => p.TargetLocation.Planet.Galaxy.Name).Returns("SomeDiferentGalaxyName");
            mockedPath.SetupGet<IEnumerable<IUnit>>(p => p.TargetLocation.Planet.Units).Returns(new List<IUnit>());
            var mockedLocation = new Mock<ILocation>();
            mockedLocation.SetupGet<string>(l => l.Planet.Name).Returns("SomePlanetName");
            mockedLocation.SetupGet<string>(l => l.Planet.Galaxy.Name).Returns("SomeGalaxyName");

            var mockedUnitToTeleport = new Mock<IUnit>();
            mockedUnitToTeleport.SetupGet<string>(u => u.CurrentLocation.Planet.Name).Returns("SomePlanetName");
            mockedUnitToTeleport.SetupGet<string>(u => u.CurrentLocation.Planet.Galaxy.Name).Returns("SomeGalaxyName");
            mockedUnitToTeleport.Setup<bool>(u => u.CanPay(It.IsAny<IResources>())).Returns(true);
            mockedUnitToTeleport.Setup<IResources>(u => u.Pay(It.IsAny<IResources>())).Returns(new Mock<IResources>().Object);
            mockedUnitToTeleport.Setup(u => u.CurrentLocation.Planet.Units.Remove(It.IsAny<IUnit>())).Returns(true);
            var mockedLocationToTeleport = new Mock<ILocation>();
            mockedLocationToTeleport.SetupGet<string>(l => l.Planet.Name).Returns("SomeDiferentPlanetName");
            mockedLocationToTeleport.SetupGet<string>(l => l.Planet.Galaxy.Name).Returns("SomeDiferentGalaxyName");

            var teleportStation = new TeleportStation(mockedOwner.Object, new List<IPath>() { mockedPath.Object}, mockedLocation.Object);

            //Act
            teleportStation.PayProfits(mockedOwner.Object);
            teleportStation.TeleportUnit(mockedUnitToTeleport.Object, mockedLocationToTeleport.Object);

            //Assert
            mockedOwner.Verify(o => o.IdentificationNumber, Times.AtLeastOnce);
            mockedPath.Verify(p => p.TargetLocation, Times.AtLeastOnce);
            mockedLocation.Verify(l => l.Planet.Name, Times.AtLeastOnce);
        }

        [TestMethod]
        public void TeleportUnit_PassNullToUnitToTeleport_ShouldThrowArgumentNullExceptionWithMessageThatContainsUnitToTeleport()
        {
            //Arrange
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedLocation = new Mock<ILocation>();
            var mockedLocationToTeleport = new Mock<ILocation>();

            var teleportStation = new TeleportStation(mockedOwner.Object, new List<IPath>(), mockedLocation.Object);

            //Act&Assert
            Assert.IsTrue(Assert.ThrowsException<ArgumentNullException>(() => teleportStation.TeleportUnit(null, mockedLocationToTeleport.Object)).Message.Contains("unitToTeleport"));
        }

        [TestMethod]
        public void TeleportUnit_PassNullToDestinaton_ShouldThrowArgumentNullExceptionWithMessageThatContainsDestination()
        {
            //Arrange
            var mockedOwner = new Mock<IBusinessOwner>();
            var mockedLocation = new Mock<ILocation>();
            var mockedUnitToTeleport = new Mock<IUnit>();

            var teleportStation = new TeleportStation(mockedOwner.Object, new List<IPath>(), mockedLocation.Object);

            //Act&Assert
            Assert.IsTrue(Assert.ThrowsException<ArgumentNullException>(() => teleportStation.TeleportUnit(mockedUnitToTeleport.Object, null)).Message.Contains("destination"));
        }

        [TestMethod]
        public void TeleportUnit_UnitTryingToUseTeleportStationFromADistanstLocation_ShouldThrowTeleportOutOfRangeExceptionWithMessageContainsUnitToTeleportCurrentLocation()
        {
            //Arrange
            var mockedOwner = new Mock<IBusinessOwner>();

            var mockedPath = new Mock<IPath>();
            var mockedLocation = new Mock<ILocation>();
            mockedLocation.SetupGet<string>(l => l.Planet.Name).Returns("SomePlanetName");
            mockedLocation.SetupGet<string>(l => l.Planet.Galaxy.Name).Returns("SomeGalaxyName");

            var mockedUnitToTeleport = new Mock<IUnit>();
            mockedUnitToTeleport.SetupGet<string>(u => u.CurrentLocation.Planet.Name).Returns("SomePlanetName2");
            mockedUnitToTeleport.SetupGet<string>(u => u.CurrentLocation.Planet.Galaxy.Name).Returns("SomeGalaxyName2");
            var mockedLocationToTeleport = new Mock<ILocation>();


            var teleportStation = new TeleportStation(mockedOwner.Object, new List<IPath>() { mockedPath.Object }, mockedLocation.Object);

            //Act&Assert
            Assert.IsTrue(Assert.ThrowsException<TeleportOutOfRangeException>(() => teleportStation.TeleportUnit(mockedUnitToTeleport.Object, mockedLocationToTeleport.Object)).Message.Contains("unitToTeleport.CurrentLocation"));
        }


    }
}
