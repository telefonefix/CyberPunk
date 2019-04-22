namespace CyberPunk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class People_Specialcapacities
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdSpecialAbility { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPerson { get; set; }

        public int? Point { get; set; }

        public virtual People People { get; set; }

        public virtual SpecialabilitiesEnum SpecialabilitiesEnum { get; set; }
    }
}
