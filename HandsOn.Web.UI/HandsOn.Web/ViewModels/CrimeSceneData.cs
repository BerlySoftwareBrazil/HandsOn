using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
#region Imports
using HandsOn.Data.Model;
#endregion
namespace HandsOn.Web.ViewModels
{
    public class CrimeSceneData
    {
        public CrimeSceneData()
        {
            Suspects = new HashSet<Suspect>();
            Places = new HashSet<Place>();
            Weapons = new HashSet<Weapon>();
        }
        public int SuspectId { get; set; }
        public int PlaceId { get; set; }
        public int WeaponId { get; set; }
        public IEnumerable<Suspect> Suspects { get; set; }
        public IEnumerable<Place> Places { get; set; }
        public IEnumerable<Weapon> Weapons { get; set; }
    }
}