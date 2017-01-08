using System;

namespace PROG6_2016_Tamagotchi.Models.Action
{
    public class SleepAction : IAction
    {
        public Tamagotchi ExectuteAction(Tamagotchi tamagotchi)
        {
            tamagotchi.Cooldown = 15;

            if (tamagotchi.Sleep > 25)
            {
                tamagotchi.Sleep -= 25;
            }
            else
            {
                tamagotchi.Sleep = 0;
            }

            if (tamagotchi.Health < 90)
            {
                tamagotchi.Health += 10;
            }
            else
            {
                tamagotchi.Health = 100;
            }

            return tamagotchi;
        }
    }
}