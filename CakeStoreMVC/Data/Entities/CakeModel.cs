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
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderHistory> OrderHistories { get; set; }
        public virtual DbSet<UserTbl> UserTbls { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flavour>()
                .Property(e => e.FlavourName)
                .IsUnicode(false);

            modelBuilder.Entity<Flavour>()
                .HasMany(e => e.FlavourTypes)
                .WithRequired(e => e.Flavour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flavour>()
                .HasMany(e => e.Menus)
                .WithRequired(e => e.Flavour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flavour>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Flavour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Flavour>()
                .HasMany(e => e.OrderHistories)
                .WithRequired(e => e.Flavour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FlavourType>()
                .Property(e => e.FlavourTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<FlavourType>()
                .Property(e => e.ImgUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderHistory>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
