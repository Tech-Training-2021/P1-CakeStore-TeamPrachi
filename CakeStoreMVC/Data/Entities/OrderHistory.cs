namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderHistory")]
    public partial class OrderHistory
    {
        public int OrderHistoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserId { get; set; }

        public int FlavourTypeID { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        [Required]
        public string ImgUrl { get; set; }

        public int FlavourID { get; set; }

        public virtual Flavour Flavour { get; set; }
    }
}
