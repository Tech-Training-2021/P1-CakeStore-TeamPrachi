using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Data.Entities
{
    public partial class CakeModel : DbContext
    {
        public CakeModel()
            : base("name=CakeModel")
        {
        }

        public virtual DbSet<CakeOrder> CakeOrders { get; set; }
        public virtual DbSet<Flavour> Flavours { get; set; }
        public virtual DbSet<FlavourType> FlavourTypes { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<UserTbl> UserTbls { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flavour>()
                .Property(e => e.FlavourName)
                .IsUnicode(false);

            modelBuilder.Entity<FlavourType>()
                .Property(e => e.FlavourTypeName)
                .IsUnicode(false);
        }
    }
}
