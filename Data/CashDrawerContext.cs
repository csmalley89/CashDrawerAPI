using Microsoft.EntityFrameworkCore;
using CashDrawer.Models;

namespace CashDrawer.Data
{
    public class CashDrawerContext : DbContext
    {
        public CashDrawerContext(DbContextOptions<CashDrawerContext> options)
            : base(options)
        { }

        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<LineItem> LineItem { get; set; }
        public DbSet<Ledger> Ledger { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .Property(b => b.TimeStamp)
                .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");

            modelBuilder.Entity<Ledger>()
                .Property(b => b.TimeStamp)
                .HasDefaultValueSql("strftime('%Y-%m-%d %H:%M:%S')");
        }
    }

}