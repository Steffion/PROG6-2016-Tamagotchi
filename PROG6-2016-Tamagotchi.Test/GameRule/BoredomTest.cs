using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PROG6_2016_Tamagotchi.Models.GameRule;
using PROG6_2016_Tamagotchi.Models;

namespace PROG6_2016_Tamagotchi.Test.GameRule
{
    [TestClass]
    public class BoredomTest
    {
        private static Random random = new Random();

        [TestMethod]
        public void Boredom()
        {
            //Arrange
            Boredom gamerule = new Boredom();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.Hunger = 100;

            //Act
            var result = gamerule.ExecuteGameRule(tamagotchi, random.Next(15, 35));

            //Assert
            Assert.AreEqual(50, result.Hunger);
        }
    }
}
