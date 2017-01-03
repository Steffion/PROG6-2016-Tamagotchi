using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PROG6_2016_Tamagotchi.Models
{
    public class Database : DbContext
    {
        public Database() : base("name=Azure")
        {
            System.Data.Entity.Database.SetInitializer(new DatabaseInitializer());
        }

        public DbSet<Tamagotchi> Tamagotchis { get; set; }
    }
}