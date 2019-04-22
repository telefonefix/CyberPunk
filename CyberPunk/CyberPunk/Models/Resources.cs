namespace CyberPunk.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Resources
    {
        [Key]
        public int IdResource { get; set; }

        public int IdPerson { get; set; }

        public int? IdCorporation { get; set; }

        public int? IdAnotherPerson { get; set; }

        public virtual Corporations Corporations { get; set; }

        public virtual People People { get; set; }

        public virtual People People1 { get; set; }
    }
}
