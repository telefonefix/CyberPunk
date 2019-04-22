namespace CyberPunk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Properties
    {
        [Key]
        public int IdProperty { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int IdDistrict { get; set; }

        public virtual Districts Districts { get; set; }
    }
}
