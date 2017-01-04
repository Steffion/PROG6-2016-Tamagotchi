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

            context.Tamagotchis.Add(new Tamagotchi() { Name = "Ger", Created = DateTime.Now, LastAccess = DateTime.Now });
            context.Tamagotchis.Add(new Tamagotchi() { Name = "Merel", Created = DateTime.Now, LastAccess = DateTime.Now });
            context.Tamagotchis.Add(new Tamagotchi() { Name = "Stijn", Created = DateTime.Now, LastAccess = DateTime.Now });
            context.Tamagotchis.Add(new Tamagotchi() { Name = "Stef", Created = DateTime.Now, LastAccess = DateTime.Now });

            context.SaveChanges();
        }
    }
}