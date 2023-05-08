using Microsoft.EntityFrameworkCore;
using ReceptionWebApi.DataContext.Configuration;
using ReceptionWebApi.DataContext.Models;
using System.Xml;

namespace ReceptionWebApi.DataContext
{
    public class GeneralContext :DbContext
    {
        public GeneralContext()
        {

        }
        public GeneralContext(DbContextOptions<GeneralContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .ApplyConfigurationsFromAssembly(typeof(GeneralContext).Assembly,
                    o =>
                        o.IsAssignableTo(typeof(IBaseEntityConfig)) &&
                        o.Name != typeof(BaseEntityConfig<,>).Name &&
                        o.Name != nameof(IBaseEntityConfig));
        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<FoodOrder> FoodOrders { get; set; }
        public DbSet<Gift> Gifts { get; set; }
        public DbSet<GiftOrder> GiftOrders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ReceptionPlace> ReceptionPlaces { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleOrder> RoleOrders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=DBReception;TrustServerCertificate=True;Trusted_Connection=True;");
        }

    }
}
