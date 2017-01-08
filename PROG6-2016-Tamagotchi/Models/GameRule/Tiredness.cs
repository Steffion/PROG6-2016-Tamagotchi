using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROG6_2016_Tamagotchi.Models.GameRule
{
    public class Tiredness : IGameRule
    {
        public Tamagotchi ExecuteGameRule(Tamagotchi tamagotchi, int value)
        {
            TimeSpan deltaTime = DateTime.UtcNow - tamagotchi.LastAccess;
            TimeSpan interval = TimeSpan.FromSeconds(10);

            while (interval.Ticks < deltaTime.Ticks)
            {
                if (tamagotchi.Sleep + value > 80 &&
                    tamagotchi.Health >= 20)
                {
                    tamagotchi.Health -= 20;
                }

                tamagotchi.Sleep += value;

                if (tamagotchi.Sleep > 100)
                {
                    tamagotchi.Sleep = 100;
                    return tamagotchi;
                }
                
                deltaTime -= interval;
            }

            return tamagotchi;
        }
    }
}