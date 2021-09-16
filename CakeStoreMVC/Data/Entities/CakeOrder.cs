namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CakeOrder")]
    public partial class CakeOrder
    {
        [Key]
        public int OrderID { get; set; }

        public int? FlavourTypeID { get; set; }

        public int? OrderedQuantity { get; set; }

        public int? TotalPrice { get; set; }

        public virtual FlavourType FlavourType { get; set; }
    }
}
