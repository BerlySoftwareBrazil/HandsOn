using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOn.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PopulateDropDownList(new Data.Model.Suspect());
            PopulateDropDownList(new Data.Model.Place());
            PopulateDropDownList(new Data.Model.Weapon());
            return View();
        }

        private void PopulateDropDownList(object T = null)
        {
            Random rd = new Random();
            switch (T.GetType().Name)
            {
                case "Suspects":
                    List<HandsOn.Data.Model.Suspect> objSuspects = new List<Data.Model.Suspect>();
                    objSuspects.Add(new Data.Model.Suspect { Id = 1, Description = "Esqueleto" });
                    objSuspects.Add(new Data.Model.Suspect { Id = 2, Description = "Khan" });
                    objSuspects.Add(new Data.Model.Suspect { Id = 3, Description = "Darth Vader" });
                    objSuspects.Add(new Data.Model.Suspect { Id = 4, Description = "Sideshow Bob" });
                    objSuspects.Add(new Data.Model.Suspect { Id = 5, Description = "Coringa" });
                    objSuspects.Add(new Data.Model.Suspect { Id = 6, Description = "Duente Verde" });
                    ViewBag.SuspectId = rd.Next(objSuspects.Min(s => s.Id), objSuspects.Max(s => s.Id));
                    ViewBag.Suspects = new SelectList(objSuspects.OrderBy(s => s.Description), "Id", "Description");
                    break;
                case "Local":
                    List<HandsOn.Data.Model.Place> objLocal = new List<Data.Model.Place>();
                    objLocal.Add(new Data.Model.Place { Id = 1, Description = "Etéria" });
                    objLocal.Add(new Data.Model.Place { Id = 2, Description = "Vulcano" });
                    objLocal.Add(new Data.Model.Place { Id = 3, Description = "Tatooine" });
                    objLocal.Add(new Data.Model.Place { Id = 4, Description = "Springfield" });
                    objLocal.Add(new Data.Model.Place { Id = 5, Description = "Gotham" });
                    objLocal.Add(new Data.Model.Place { Id = 6, Description = "Nova York" });
                    objLocal.Add(new Data.Model.Place { Id = 7, Description = "Sibéria" });
                    objLocal.Add(new Data.Model.Place { Id = 8, Description = "Machu Picchu" });
                    objLocal.Add(new Data.Model.Place { Id = 9, Description = "Show do Katinguele" });
                    objLocal.Add(new Data.Model.Place { Id = 10, Description = "São Paulo" });
                    ViewBag.PlaceId = rd.Next(objLocal.Min(p => p.Id), objLocal.Max(p => p.Id));
                    ViewBag.Places = new SelectList(objLocal.OrderBy(p => p.Description), "Id", "Description");
                    break;
                case "Weapons":
                    List<HandsOn.Data.Model.Weapon> objWeapons = new List<Data.Model.Weapon>();
                    objWeapons.Add(new Data.Model.Weapon { Id = 1, Description = "Cajado Devastador" });
                    objWeapons.Add(new Data.Model.Weapon { Id = 2, Description = "Phaser" });
                    objWeapons.Add(new Data.Model.Weapon { Id = 3, Description = "Peixeira" });
                    objWeapons.Add(new Data.Model.Weapon { Id = 4, Description = "Trezoitão" });
                    objWeapons.Add(new Data.Model.Weapon { Id = 5, Description = "Sabre de Luz" });
                    objWeapons.Add(new Data.Model.Weapon { Id = 6, Description = "Bomba" });
                    ViewBag.WeaponId = rd.Next(objWeapons.Min(w => w.Id), objWeapons.Max(w => w.Id));
                    ViewBag.Weapons = new SelectList(objWeapons.OrderBy(w => w.Description), "Id", "Description");
                    break;
                default:
                    break;
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}