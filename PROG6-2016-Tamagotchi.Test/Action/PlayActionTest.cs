using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PROG6_2016_Tamagotchi.Models.Action;
using PROG6_2016_Tamagotchi.Models;

namespace PROG6_2016_Tamagotchi.Test.Action
{
    [TestClass]
    public class PlayActionTest
    {
        [TestMethod]
        public void PlayAction_BoredMinus35()
        {
            //Arrange
            PlayAction action = new PlayAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Bored = 100;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(65, result.Bored);
        }

        [TestMethod]
        public void PlayAction_Below35_Bored0()
        {
            //Arrange
            PlayAction action = new PlayAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Bored = 20;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(0, result.Bored);
        }

        [TestMethod]
        public void PlayAction_Random_Between90And100()
        {
            //Arrange
            PlayAction action = new PlayAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Health = 100;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(true, result.Health == 100 || result.Health == 90);
        }

        [TestMethod]
        public void PlayAction_Random_Between0And10()
        {
            //Arrange
            PlayAction action = new PlayAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Bored = 10;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(true, result.Bored == 0 || result.Bored == 10);
        }
    }
}
