using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROG6_2016_Tamagotchi.Models
{
    public class Tamagotchi
    {
        [Key]
        public int Id { get; set; }

        public String Name { get; set; }

        public DateTime LastAccess { get; set; }

        public DateTime Created { get; set; }

        public int Age { get; set; }

        public int Hunger { get; set; }

        public int Sleep { get; set; }

        public int Bored { get; set; }

        public int Health { get; set; }
    }
}