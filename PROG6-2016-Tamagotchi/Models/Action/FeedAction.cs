using System;

namespace PROG6_2016_Tamagotchi.Models.Action
{
    public class FeedAction : IAction
    {
        public Tamagotchi ExectuteAction(Tamagotchi tamagotchi)
        {
            tamagotchi.Cooldown = 5;

            if (tamagotchi.Hunger > 50)
            {
                tamagotchi.Hunger -= 50;
            }
            else
            {
                tamagotchi.Hunger = 0;
            }

            Random random = new Random();

            if (random.Next(1,10) == 1)
            {
                if (tamagotchi.Health > 20)
                {
                    tamagotchi.Health -= 20;
                }
                else
                {
                    tamagotchi.Health = 0;
                }
            }

            return tamagotchi;
        }
    }
}