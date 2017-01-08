using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROG6_2016_Tamagotchi.Models
{
   

    public class TamagotchiList
    {
        public List<Tamagotchi> Tamagotchies { get; set; }

        public TamagotchiList()
        {
            Tamagotchies = new List<Tamagotchi>();
        }
    }
}