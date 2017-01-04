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
            
            if (tamagotchi.Bored > 80)
            {
                value = value * 2;
            }

            while (interval.Ticks < deltaTime.Ticks)
            {
                if (tamagotchi.Hunger + value > 80 &&
                    tamagotchi.Health >= 20)
                {
                    tamagotchi.Health -= 20;
                }
                
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