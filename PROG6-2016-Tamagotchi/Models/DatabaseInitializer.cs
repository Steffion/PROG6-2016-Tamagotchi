using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PROG6_2016_Tamagotchi.Models
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<Database>
    {
        protected override void Seed(Database context)
        {
            base.Seed(context);

            context.Tamagotchis.Add(new Tamagotchi() { Name = "Ger" });
            context.Tamagotchis.Add(new Tamagotchi() { Name = "Merel" });
            context.Tamagotchis.Add(new Tamagotchi() { Name = "Stijn" });
            context.Tamagotchis.Add(new Tamagotchi() { Name = "Stef" });

            context.SaveChanges();
        }
    }
}