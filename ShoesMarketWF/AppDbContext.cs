using Microsoft.EntityFrameworkCore;
using ShoesMarketWF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesMarketWF
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<PickupPointEntity> PickupPoints { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<OrderDetailsEntity> OrdersDetailes { get; set; }

        public AppDbContext()
        {
            
        }
        public AppDbContext(DbContextOptions options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID = postgres; database = SchoesMarket; HOST = localhost; Port = 5432; Password = 2245;");
        }
    }
}
