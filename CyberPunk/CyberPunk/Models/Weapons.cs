namespace CyberPunk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Weapons
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Weapons()
        {
            Bullets = new HashSet<Bullets>();
        }

        [Key]
        public int IdWeapon { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Precision { get; set; }

        public int Ammunition { get; set; }

        public bool Quiet { get; set; }

        public int DiceQty { get; set; }

        public int Extra { get; set; }

        public int Range { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public int IdDice { get; set; }

        public virtual Dices Dices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bullets> Bullets { get; set; }
    }
}
