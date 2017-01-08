using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PROG6_2016_Tamagotchi.Models.Action;
using PROG6_2016_Tamagotchi.Models;

namespace PROG6_2016_Tamagotchi.Test.Action
{
    [TestClass]
    public class HugActionTest
    {
        [TestMethod]
        public void HugAction_HungerMinus10()
        {
            //Arrange
            HugAction action = new HugAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Hunger = 100;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(90, result.Hunger);
        }

        [TestMethod]
        public void HugAction_SleepMinus10()
        {
            //Arrange
            HugAction action = new HugAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Sleep = 100;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(90, result.Sleep);
        }

        [TestMethod]
        public void HugAction_BoredMinus10()
        {
            //Arrange
            HugAction action = new HugAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Bored = 100;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(90, result.Bored);
        }

        [TestMethod]
        public void HugAction_Below10_Hunger0()
        {
            //Arrange
            HugAction action = new HugAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Hunger = 5;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(0, result.Hunger);
        }

        [TestMethod]
        public void HugAction_Below10_Sleep0()
        {
            //Arrange
            HugAction action = new HugAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Sleep = 5;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(0, result.Sleep);
        }

        [TestMethod]
        public void HugAction_Below10_Bored0()
        {
            //Arrange
            HugAction action = new HugAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Bored = 5;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(0, result.Bored);
        }

        [TestMethod]
        public void HugAction_HealthPlus10()
        {
            //Arrange
            HugAction action = new HugAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Health = 90;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(100, result.Health);
        }

        [TestMethod]
        public void HugAction_Health_Above90_Sets100()
        {
            //Arrange
            HugAction action = new HugAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Health = 95;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(100, result.Health);
        }
    }
}
