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
        public void Boredom_Interval_BoredomIs100()
        {
            //Arrange
            Boredom gamerule = new Boredom();
            Tamagotchi tamagotchi = new Tamagotchi();

            DateTime time = DateTime.UtcNow;
            time = time.Subtract(TimeSpan.FromSeconds(50));

            tamagotchi.LastAccess = time;
            tamagotchi.Bored = 50;
            
            //Act
            var result = gamerule.ExecuteGameRule(tamagotchi, random.Next(15, 35));

            //Assert
            Assert.AreEqual(100, result.Bored);
        }

        [TestMethod]
        public void Boredom_Above100_BoredomIs100()
        {
            //Arrange
            Boredom gamerule = new Boredom();
            Tamagotchi tamagotchi = new Tamagotchi();

            DateTime time = DateTime.UtcNow;
            time = time.Subtract(TimeSpan.FromSeconds(10));

            tamagotchi.LastAccess = time;
            tamagotchi.Bored = 100;

            //Act
            var result = gamerule.ExecuteGameRule(tamagotchi, random.Next(15, 35));

            //Assert
            Assert.AreEqual(100, result.Bored);
        }

        [TestMethod]
        public void Boredom_NoInterval()
        {
            //Arrange
            Boredom gamerule = new Boredom();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.LastAccess = DateTime.UtcNow;
            tamagotchi.Bored = 100;

            //Act
            var result = gamerule.ExecuteGameRule(tamagotchi, random.Next(15, 35));

            //Assert
            Assert.AreEqual(100, result.Bored);
        }
    }
}
