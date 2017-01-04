using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROG6_2016_Tamagotchi.Models.GameRule
{
    public class Hunger : IGameRule
    {
        public Tamagotchi ExecuteGameRule(Tamagotchi tamagotchi, int value)
        {
            TimeSpan deltaTime = DateTime.Now - tamagotchi.LastAccess;
            TimeSpan interval = TimeSpan.FromSeconds(10);

            while (interval.Ticks < deltaTime.Ticks)
            {
                tamagotchi.Hunger += value;

                if (tamagotchi.Hunger > 100)
                {
                    tamagotchi.Hunger = 100;
                    return tamagotchi;
                }

                deltaTime -= interval;
            }

            return tamagotchi;
        }
    }
}