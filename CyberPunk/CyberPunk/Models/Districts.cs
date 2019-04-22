namespace CyberPunk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Districts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Districts()
        {
            Places = new HashSet<Places>();
            Properties = new HashSet<Properties>();
        }

        [Key]
        public int IdDistrict { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Safe { get; set; }

        public int IdCity { get; set; }

        public virtual Cities Cities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Places> Places { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Properties> Properties { get; set; }
    }
}
