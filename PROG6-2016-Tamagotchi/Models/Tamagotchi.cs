using PROG6_2016_Tamagotchi.Models.Action;
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
        private static Random random = new Random();

        [Key]
        public int Id { get; set; }

        public String Name { get; set; }

        public int Cooldown { get; set; }

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

        private HugAction feed = new HugAction();
        private SleepAction sleepA = new SleepAction();
        private PlayAction play = new PlayAction();
        private HugAction hug = new HugAction();

        public void UpdateStatus()
        {
            Sleep = tiredness.ExecuteGameRule(this, random.Next(15, 35)).Sleep;
            Bored = boredom.ExecuteGameRule(this, random.Next(15, 35)).Bored;
            Hunger = hunger.ExecuteGameRule(this, random.Next(15, 35)).Hunger;

            if (Health > 0)
            {
                TimeSpan deltaTime = DateTime.UtcNow - LastAccess;
                Age += deltaTime.Seconds;
            }

            if (Cooldown > 0)
            {
                TimeSpan deltaTime = DateTime.UtcNow - LastAccess;

                if (Cooldown - deltaTime.Seconds < 0)
                {
                    Cooldown = 0;
                }
                else
                {
                    Cooldown -= deltaTime.Seconds;
                }
            }

            LastAccess = DateTime.UtcNow;
        }

        public void Feed()
        {
            feed.ExectuteAction(this);
        }

        public void SleepA()
        {
            sleepA.ExectuteAction(this);
        }

        public void Play()
        {
            play.ExectuteAction(this);
        }

        public void Hug()
        {
            hug.ExectuteAction(this);
        }
    }
}