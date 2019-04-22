namespace CyberPunk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Weaponfamilies
    {
        [Key]
        public int IdWeaponFamily { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
