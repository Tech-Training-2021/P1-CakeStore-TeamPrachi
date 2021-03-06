namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FlavourType")]
    public partial class FlavourType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FlavourType()
        {
            CakeOrders = new HashSet<CakeOrder>();
        }

        public int FlavourTypeID { get; set; }

        public int FlavourID { get; set; }

        [StringLength(100)]
        public string FlavourTypeName { get; set; }

        public int? Price { get; set; }

        public int? AvailableQuantity { get; set; }

        public string ImgUrl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CakeOrder> CakeOrders { get; set; }

        public virtual Flavour Flavour { get; set; }
    }
}
