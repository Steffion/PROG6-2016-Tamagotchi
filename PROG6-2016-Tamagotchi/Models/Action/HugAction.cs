using System;

namespace PROG6_2016_Tamagotchi.Models.Action
{
    public class HugAction : IAction
    {
        public Tamagotchi ExectuteAction(Tamagotchi tamagotchi)
        {
            tamagotchi.Cooldown = 3;

            if (tamagotchi.Hunger > 10)
            {
                tamagotchi.Hunger -= 10;
            }
            else
            {
                tamagotchi.Hunger = 0;
            }

            if (tamagotchi.Sleep > 10)
            {
                tamagotchi.Sleep -= 10;
            }
            else
            {
                tamagotchi.Sleep = 0;
            }

            if (tamagotchi.Bored > 10)
            {
                tamagotchi.Bored -= 10;
            }
            else
            {
                tamagotchi.Bored = 0;
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