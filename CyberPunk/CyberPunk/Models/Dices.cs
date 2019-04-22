namespace CyberPunk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dices
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dices()
        {
            Weapons = new HashSet<Weapons>();
        }

        [Key]
        public int IdDice { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? MaxValue { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Weapons> Weapons { get; set; }
    }
}
