using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PROG6_2016_Tamagotchi.Models.GameRule;
using PROG6_2016_Tamagotchi.Models;

namespace PROG6_2016_Tamagotchi.Test.GameRule
{
    [TestClass]
    public class HungerTest
    {
        private static Random random = new Random();

        [TestMethod]
        public void Hunger_Interval_HungerIs100()
        {
            //Arrange
            Hunger gamerule = new Hunger();
            Tamagotchi tamagotchi = new Tamagotchi();

            DateTime time = DateTime.UtcNow;
            time = time.Subtract(TimeSpan.FromSeconds(50));

            tamagotchi.LastAccess = time;
            tamagotchi.Hunger = 50;
            
            //Act
            var result = gamerule.ExecuteGameRule(tamagotchi, random.Next(15, 35));

            //Assert
            Assert.AreEqual(100, result.Hunger);
        }

        [TestMethod]
        public void Hunger_Above100_HungerIs100()
        {
            //Arrange
            Hunger gamerule = new Hunger();
            Tamagotchi tamagotchi = new Tamagotchi();

            DateTime time = DateTime.UtcNow;
            time = time.Subtract(TimeSpan.FromSeconds(10));

            tamagotchi.LastAccess = time;
            tamagotchi.Hunger = 100;

            //Act
            var result = gamerule.ExecuteGameRule(tamagotchi, random.Next(15, 35));

            //Assert
            Assert.AreEqual(100, result.Hunger);
        }

        [TestMethod]
        public void Hunger_BoredAbove80_Multiply2()
        {
            //Arrange
            Hunger gamerule = new Hunger();
            Tamagotchi tamagotchi = new Tamagotchi();

            DateTime time = DateTime.UtcNow;
            time = time.Subtract(TimeSpan.FromSeconds(10));

            tamagotchi.LastAccess = time;
            tamagotchi.Hunger = 0;
            tamagotchi.Bored = 81;

            var randomint = random.Next(15, 35);

            //Act
            var result = gamerule.ExecuteGameRule(tamagotchi, randomint);

            //Assert
            Assert.AreEqual(randomint * 2, result.Hunger);
        }

        [TestMethod]
        public void Hunger_NoInterval()
        {
            //Arrange
            Hunger gamerule = new Hunger();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.LastAccess = DateTime.UtcNow;
            tamagotchi.Hunger = 100;

            //Act
            var result = gamerule.ExecuteGameRule(tamagotchi, random.Next(15, 35));

            //Assert
            Assert.AreEqual(100, result.Hunger);
        }
    }
}
