using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROG6_2016_Tamagotchi.Models.GameRule
{
    public class Boredom : IGameRule
    {
        public Tamagotchi ExecuteGameRule(Tamagotchi tamagotchi, int value)
        {
            TimeSpan deltaTime = DateTime.UtcNow - tamagotchi.LastAccess;
            TimeSpan interval = TimeSpan.FromSeconds(10);

            while (interval.Ticks <= deltaTime.Ticks)
            {
                tamagotchi.Bored += value;

                if (tamagotchi.Bored > 100)
                {
                    tamagotchi.Bored = 100;
                    return tamagotchi;
                }

                deltaTime -= interval;
            }

            return tamagotchi;
        }
    }
}