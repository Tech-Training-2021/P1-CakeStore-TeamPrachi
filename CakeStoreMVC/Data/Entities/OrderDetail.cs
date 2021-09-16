namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderDetail
    {
        [Key]
        public int OrderDetailsID { get; set; }

        public int? FlavourTypeID { get; set; }

        public int? OrderedQuantity { get; set; }

        public int? TotalPrice { get; set; }

        public virtual FlavourType FlavourType { get; set; }
    }
}
