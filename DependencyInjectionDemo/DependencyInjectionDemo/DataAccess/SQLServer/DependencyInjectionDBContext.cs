using DependencyInjectionDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.DataAccess.SQLServer
{
    public class DependencyInjectionDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public DependencyInjectionDBContext(string connectionString) : base(connectionString) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapping for Items Table
            modelBuilder.Entity<Item>().ToTable("Items", "dbo");
            modelBuilder.Entity<Item>().Ignore(x => x.DatabaseTechnology);
            modelBuilder.Entity<Item>().Property(x => x.CreatedDate).IsOptional();
            modelBuilder.Entity<Item>().HasKey(x => x.Id);
            modelBuilder.Entity<Item>().Property(x => x.Name).HasMaxLength(100);
            modelBuilder.Entity<Item>().Property(x => x.CreatedUser).HasMaxLength(50);
        }
    }
}
