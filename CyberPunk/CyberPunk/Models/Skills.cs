namespace CyberPunk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Skills
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Skills()
        {
            Add_skills = new HashSet<Add_skills>();
            People = new HashSet<People>();
        }

        [Key]
        public int IdSkill { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Value { get; set; }

        public int IdSkillEnum { get; set; }

        public int idFeature { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Add_skills> Add_skills { get; set; }

        public virtual Features Features { get; set; }

        public virtual SkillEnum SkillEnum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<People> People { get; set; }
    }
}
