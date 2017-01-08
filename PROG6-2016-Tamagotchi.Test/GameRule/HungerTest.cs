using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PROG6_2016_Tamagotchi.Models.GameRule;
using PROG6_2016_Tamagotchi.Models;

namespace PROG6_2016_Tamagotchi.Test.GameRule
{
    [TestClass]
    public class TirednessTest
    {
        private static Random random = new Random();

        [TestMethod]
        public void Tiredness_Interval_TirednessIs100()
        {
            //Arrange
            Tiredness gamerule = new Tiredness();
            Tamagotchi tamagotchi = new Tamagotchi();

            DateTime time = DateTime.UtcNow;
            time = time.Subtract(TimeSpan.FromSeconds(50));

            tamagotchi.LastAccess = time;
            tamagotchi.Sleep = 50;
            
            //Act
            var result = gamerule.ExecuteGameRule(tamagotchi, random.Next(15, 35));

            //Assert
            Assert.AreEqual(100, result.Sleep);
        }

        [TestMethod]
        public void Tiredness_Above100_TirednessIs100()
        {
            //Arrange
            Tiredness gamerule = new Tiredness();
            Tamagotchi tamagotchi = new Tamagotchi();

            DateTime time = DateTime.UtcNow;
            time = time.Subtract(TimeSpan.FromSeconds(10));

            tamagotchi.LastAccess = time;
            tamagotchi.Sleep = 100;

            //Act
            var result = gamerule.ExecuteGameRule(tamagotchi, random.Next(15, 35));

            //Assert
            Assert.AreEqual(100, result.Sleep);
        }

        [TestMethod]
        public void Tiredness_NoInterval()
        {
            //Arrange
            Tiredness gamerule = new Tiredness();
            Tamagotchi tamagotchi = new Tamagotchi();

            tamagotchi.LastAccess = DateTime.UtcNow;
            tamagotchi.Sleep = 100;

            //Act
            var result = gamerule.ExecuteGameRule(tamagotchi, random.Next(15, 35));

            //Assert
            Assert.AreEqual(100, result.Sleep);
        }
    }
}
