using Microsoft.EntityFrameworkCore;
using SimplePropertyInvesting.Models;

namespace SimplePropertyInvesting.Context
{
    public class InvestContext: DbContext
    {
        public InvestContext(DbContextOptions options):base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Property>()
        //        .WithMany(o => o.Units)
        //        .HasForeignKey(u => u.UserID);

        //    modelBuilder.Entity<>()
        //        .HasOne(s => s.Stock)
        //        .WithMany(o => o.Order)
        //        .HasForeignKey(s => s.StockID);

        //}




        public DbSet<Property> properties { get; set; }
        public DbSet<Tenant> tenants { get; set; }
        public DbSet<Unit> units { get; set; }
        public DbSet<User> users { get; set; }

        


    }
}
