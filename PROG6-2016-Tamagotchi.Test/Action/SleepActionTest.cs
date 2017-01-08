using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PROG6_2016_Tamagotchi.Models.Action;
using PROG6_2016_Tamagotchi.Models;

namespace PROG6_2016_Tamagotchi.Test.Action
{
    [TestClass]
    public class SleepActionTest
    {
        [TestMethod]
        public void SleepAction_SleepMinus25()
        {
            //Arrange
            SleepAction action = new SleepAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Sleep = 100;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(75, result.Sleep);
        }

        [TestMethod]
        public void SleepAction_HealthPlus10()
        {
            //Arrange
            SleepAction action = new SleepAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Health = 90;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(100, result.Health);
        }

        [TestMethod]
        public void SleepAction_Below25_Sleep0()
        {
            //Arrange
            SleepAction action = new SleepAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Sleep = 10;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(0, result.Sleep);
        }

        [TestMethod]
        public void SleepAction_Above90_Health100()
        {
            //Arrange
            SleepAction action = new SleepAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Health = 95;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(100, result.Health);
        }
    }
}
