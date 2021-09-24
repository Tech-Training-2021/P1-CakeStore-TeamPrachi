namespace Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        public int MenuId { get; set; }

        public int FlavourID { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public virtual Flavour Flavour { get; set; }
    }
}
