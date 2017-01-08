using System;

namespace PROG6_2016_Tamagotchi.Models.Action
{
    public class PlayAction : IAction
    {
        public Tamagotchi ExectuteAction(Tamagotchi tamagotchi)
        {
            tamagotchi.Cooldown = 8;

            if (tamagotchi.Bored > 35)
            {
                tamagotchi.Bored -= 35;
            }
            else
            {
                tamagotchi.Bored = 0;
            }

            Random random = new Random();

            if (random.Next(1,20) == 1)
            {
                if (tamagotchi.Health > 10)
                {
                    tamagotchi.Health -= 10;
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