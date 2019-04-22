namespace CyberPunk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SpecialabilitiesEnum")]
    public partial class SpecialabilitiesEnum
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SpecialabilitiesEnum()
        {
            People_Specialcapacities = new HashSet<People_Specialcapacities>();
            Specialabilities = new HashSet<Specialabilities>();
        }

        [Key]
        public int IdSpecialAbilityEnum { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int Coefficient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<People_Specialcapacities> People_Specialcapacities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specialabilities> Specialabilities { get; set; }
    }
}
