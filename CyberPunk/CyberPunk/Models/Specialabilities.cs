namespace CyberPunk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Specialabilities
    {
        [Key]
        public int IdSpecialAbility { get; set; }

        public int Valeur { get; set; }

        public int? AcquiredPoints { get; set; }

        public int IdSpecialAbilityEnum { get; set; }

        public virtual SpecialabilitiesEnum SpecialabilitiesEnum { get; set; }
    }
}
