namespace CyberPunk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Grades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grades()
        {
            People = new HashSet<People>();
        }

        [Key]
        public int IdGrade { get; set; }

        public int IdEnumgrade { get; set; }

        public int Level { get; set; }

        public int Resource { get; set; }

        public int Salary { get; set; }

        public virtual Enumgrades Enumgrades { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<People> People { get; set; }
    }
}
