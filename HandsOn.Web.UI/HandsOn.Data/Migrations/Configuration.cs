namespace HandsOn.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    #region Imports
    using HandsOn.Data.Model;
    using System.Collections.Generic;
    #endregion
    internal sealed class Configuration : DbMigrationsConfiguration<HandsOn.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HandsOn.Data.ApplicationDbContext context)
        {
            var places = new List<Place> {
                new Place{ Description = "Etérnia", Discriminator = "Place"},
                new Place{ Description = "Vulcano", Discriminator = "Place"},
                new Place{ Description = "Tatooine", Discriminator = "Place"},
                new Place{ Description = "Springfield", Discriminator = "Place"},
                new Place{ Description = "Gotham", Discriminator = "Place"},
                new Place{ Description = "Nova York", Discriminator = "Place"},
                new Place{ Description = "Sibéria", Discriminator = "Place"},
                new Place{ Description = "Machu Picchu", Discriminator = "Place"},
                new Place{ Description = "Show do Katinguele", Discriminator = "Place"},
                new Place{ Description = "São Paulo", Discriminator = "Place"}
            };

            places.ForEach(s => context.Places.AddOrUpdate(p => p.Description, s));
            context.SaveChanges();

            var suspects = new List<Suspect>{
                new Suspect{ Description = "Esqueleto", Discriminator = "Suspect"},
                new Suspect{ Description = "Khan", Discriminator = "Suspect"},
                new Suspect{ Description = "Darth Vader", Discriminator = "Suspect"},
                new Suspect{ Description = "Sideshow Bob", Discriminator = "Suspect"},
                new Suspect{ Description = "Coringa", Discriminator = "Suspect"},
                new Suspect{ Description = "Duente Verde", Discriminator = "Suspect"}
            };
            suspects.ForEach(s => context.Suspects.AddOrUpdate(u => u.Description, s));
            context.SaveChanges();

            var weapons = new List<Weapon> {
                new Weapon{ Description = "Cajado Devastador", Discriminator = "Weapon"},
                new Weapon{ Description = "Phaser", Discriminator = "Weapon"},
                new Weapon{ Description = "Peixeira", Discriminator = "Weapon"},
                new Weapon{ Description = "Trezoitão", Discriminator = "Weapon"},
                new Weapon{ Description = "Sabre de Luz", Discriminator = "Weapon"},
                new Weapon{ Description = "Bomba", Discriminator = "Weapon"}
            };
            weapons.ForEach(s => context.Weapons.AddOrUpdate(w => w.Description, s));
            context.SaveChanges();
        }
    }
}
