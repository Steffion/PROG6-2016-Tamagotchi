using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PROG6_2016_Tamagotchi.Models.Action;
using PROG6_2016_Tamagotchi.Models;

namespace PROG6_2016_Tamagotchi.Test.Action
{
    [TestClass]
    public class FeedActionTest
    {
        [TestMethod]
        public void FeedAction_HungerMinus50()
        {
            //Arrange
            FeedAction action = new FeedAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Hunger = 100;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(50, result.Hunger);
        }

        [TestMethod]
        public void FeedAction_Below50_Hunger0()
        {
            //Arrange
            FeedAction action = new FeedAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Hunger = 25;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(0, result.Hunger);
        }

        [TestMethod]
        public void FeedAction_Random_Between100And80()
        {
            //Arrange
            FeedAction action = new FeedAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Health = 100;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(true, result.Health == 100 || result.Health == 80);
        }

        [TestMethod]
        public void FeedAction_Random_Between0And20()
        {
            //Arrange
            FeedAction action = new FeedAction();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Health = 20;

            //Act
            var result = action.ExectuteAction(tamagotchi);

            //Assert
            Assert.AreEqual(true, result.Hunger == 0 || result.Hunger == 20);
        }
    }
}
