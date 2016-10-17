using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArmyOfCreatures.Logic.Battles;
using Moq;
using Moq.Protected;
using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Creatures;
using System.Collections.Generic;
using ArmyOfCreatures.Logic.Specialties;

namespace ArmyOfCreatures.Test
{
    [TestClass]
    public class BatleManagerTest
    {
        [TestMethod]
        public void Constructor_PassCorrectObjectsAsParameter_ShouldContainPassedObjects()
        {
            var mockedCreaturesFactory = new Mock<ICreaturesFactory>().Object;
            var mockedLogger = new Mock<ILogger>().Object;

            var batleManager = new BattleManager(mockedCreaturesFactory, mockedLogger);

            var privateFactory = new PrivateObject(batleManager);

            var factory = privateFactory.GetField("creaturesFactory");
            var logger = privateFactory.GetField("logger");

            Assert.AreSame(mockedCreaturesFactory, factory,"factory not same");
            Assert.AreSame(mockedLogger, logger,"logger not same");
        }

        [TestMethod]
        public void Attack_PerformAttackWithOneCreatureInEveryArmy_AttackAndDefendCretureShouldPerformTurn()
        {
            var mockedCreaturesFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var mockedManager = new Mock<BattleManager>(mockedCreaturesFactory.Object, mockedLogger.Object);
            var mockedAttacker = new Mock<ICreaturesInBattle>();            
            mockedAttacker.SetupGet<Creature>(bc => bc.Creature).Returns(new Archangel());
            var mockedDefender = new Mock<ICreaturesInBattle>();
            mockedDefender.SetupGet<Creature>(bc => bc.Creature).Returns(new Archangel());

            mockedManager.Protected().Setup<ICreaturesInBattle>("GetByIdentifier",ItExpr.IsAny<CreatureIdentifier>()).Returns<CreatureIdentifier>(i =>
            {
                if (i.ArmyNumber == 1)
                {
                    return mockedAttacker.Object;
                }
                else if (i.ArmyNumber == 2)
                {
                    return mockedDefender.Object;
                }

                return null;
            }).Verifiable();


            mockedManager.Object.Attack(CreatureIdentifier.CreatureIdentifierFromString("FirstArmyCrature(1"), CreatureIdentifier.CreatureIdentifierFromString("SecondArmyCrature(2"));

            mockedAttacker.Verify(a => a.StartNewTurn(), Times.Exactly(1), "incorect attacker turns");
            mockedDefender.Verify(d => d.StartNewTurn(), Times.Exactly(1), "incorect defender turns");
        }


    }
}
