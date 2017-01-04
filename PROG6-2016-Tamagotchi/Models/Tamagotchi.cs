using PROG6_2016_Tamagotchi.Models.GameRule;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROG6_2016_Tamagotchi.Models
{
    public class Tamagotchi
    {
        [Key]
        public int Id { get; set; }

        public String Name { get; set; }

        public DateTime LastAccess { get; set; }

        public DateTime Created { get; set; }

        public int Age { get; set; }

        public int Hunger { get; set; }

        public int Sleep { get; set; }

        public int Bored { get; set; }

        public int Health { get; set; }
        
        private Tiredness tiredness = new Tiredness();
        private Boredom boredom = new Boredom();
        private Hunger hunger = new Hunger();

        public void UpdateStatus()
        {
            Random random = new Random();

            Sleep = tiredness.ExecuteGameRule(this, random.Next(15, 35)).Sleep;
            Bored = boredom.ExecuteGameRule(this, random.Next(15, 35)).Bored;
            Hunger = hunger.ExecuteGameRule(this, random.Next(15, 35)).Hunger;

            if (Health > 0)
            {
                TimeSpan deltaTime = DateTime.Now - LastAccess;
                Age += deltaTime.Seconds;
            }

            LastAccess = DateTime.Now;
        }
    }
}