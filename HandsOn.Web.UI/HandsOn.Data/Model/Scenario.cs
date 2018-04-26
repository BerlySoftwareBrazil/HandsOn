using System;
using System.Collections.Generic;
#region Imports
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion
namespace HandsOn.Data.Model
{
    public class Scenario
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Discriminator { get; set; }
    }
}
