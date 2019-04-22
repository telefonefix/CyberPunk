namespace CyberPunk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class People
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public People()
        {
            Resources = new HashSet<Resources>();
            Resources1 = new HashSet<Resources>();
            Spoken = new HashSet<Spoken>();
            People_Specialcapacities = new HashSet<People_Specialcapacities>();
            PATENTS = new HashSet<PATENTS>();
            Features = new HashSet<Features>();
            Skills = new HashSet<Skills>();
        }

        [Key]
        public int IdPerson { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        public bool Gender { get; set; }

        public int? Size { get; set; }

        public int? Weight { get; set; }

        public int? Age { get; set; }

        public int? Point { get; set; }

        public int? Hurt { get; set; }

        public int Chance { get; set; }

        public int IdRole { get; set; }

        public int? IdCorporation { get; set; }

        public int? IdGrade { get; set; }

        public int? IdPlace { get; set; }

        public virtual Corporations Corporations { get; set; }

        public virtual Grades Grades { get; set; }

        public virtual Places Places { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resources> Resources { get; set; }

        public virtual Roles Roles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Resources> Resources1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Spoken> Spoken { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<People_Specialcapacities> People_Specialcapacities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PATENTS> PATENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Features> Features { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Skills> Skills { get; set; }
    }
}
