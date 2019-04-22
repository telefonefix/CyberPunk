namespace CyberPunk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Armors
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Armors()
        {
            Bodies = new HashSet<Bodies>();
        }

        [Key]
        public int IdArmor { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int PA { get; set; }

        public int Congestion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bodies> Bodies { get; set; }
    }
}
