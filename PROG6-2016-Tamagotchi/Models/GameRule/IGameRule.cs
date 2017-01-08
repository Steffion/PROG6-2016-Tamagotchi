using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROG6_2016_Tamagotchi.Models.GameRule
{
    public interface IGameRule
    {
        Tamagotchi ExecuteGameRule(Tamagotchi tamagotchi, int value);
    }
}