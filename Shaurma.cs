namespace BackendCoffee
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shaurma")]
    public partial class Shaurma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int primaryKey { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        [StringLength(255)]
        public string Price { get; set; }

        public int? ReadyMadeKits { get; set; }

        public bool? Availability { get; set; }
    }
}
