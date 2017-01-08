using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROG6_2016_Tamagotchi.Models.Action
{
    public interface IAction
    {
        Tamagotchi ExectuteAction(Tamagotchi tamagotchi);
    }
}