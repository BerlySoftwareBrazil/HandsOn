using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
#region Imports
using HandsOn.Data;
using HandsOn.Web.ViewModels;
using System.Threading.Tasks;
#endregion
namespace HandsOn.Web.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Home
        public ActionResult Index()
        {
            PopulatePlacesDropDownList();
            PopulateSuspectsDropDownList();
            PopulateWeaponsDropDownList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(FormCollection form)
        {
            int suspect = int.Parse(form["SuspectId"]);
            int place = int.Parse(form["PlaceId"]);
            int weapon = int.Parse(form["WeaponId"]);
            int selectedSuspects = int.Parse(form["SelectedSuspects"]);
            int selectedPlaces = int.Parse(form["SelectedPlaces"]);
            int selectedWeapons = int.Parse(form["SelectedWeapons"]);
            return View();
        }

        private void PopulateWeaponsDropDownList(int? selectedSuspects = null)
        {
            var suspects = db.Suspects.OrderBy(p => p.Description).ToList();
            ViewBag.SelectedSuspects = new SelectList(suspects, "Id", "Description", selectedSuspects);
            ViewBag.SuspectId = SelectedSuspectRandon(suspects);
        }

        private int SelectedSuspectRandon(IEnumerable<Data.Model.Suspect> suspects)
        {
            Random rd = new Random();
            return rd.Next(suspects.Min(s => s.Id), suspects.Max(s => s.Id));
        }


        private void PopulateSuspectsDropDownList(int? selectedWeapons = null)
        {
            var weapons = db.Weapons.OrderBy(p => p.Description).ToList();
            ViewBag.SelectedWeapons = new SelectList(weapons, "Id", "Description", selectedWeapons);
            ViewBag.WeaponId = SelectedWeaponRandon(weapons);
        }

        private int SelectedWeaponRandon(IEnumerable<Data.Model.Weapon> weapons)
        {
            Random rd = new Random();
            return rd.Next(weapons.Min(s => s.Id), weapons.Max(s => s.Id));
        }

        private void PopulatePlacesDropDownList(int? selectedPlaces = null)
        {
            var places = db.Places.OrderBy(p => p.Description).ToList();
            ViewBag.SelectedPlaces = new SelectList(places, "Id", "Description", selectedPlaces);
            ViewBag.PlaceId = SelectedPlaceRandon(places);
        }

        private int SelectedPlaceRandon(IEnumerable<Data.Model.Place> places)
        {
            Random rd = new Random();
            return rd.Next(places.Min(s => s.Id), places.Max(s => s.Id));
        }
    }
}