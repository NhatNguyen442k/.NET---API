using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj.API.Models
{
    public class DBcontext : DbContext
    {
        public DBcontext(DbContextOptions<DBcontext> options)
            : base(options)
        {
            
        }
        public DbSet<Categories> categories { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<Account> account { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .HasNoKey();
            modelBuilder.Entity<Infoorder>()
                .HasNoKey();
        }
        public DbSet<Users> users { get; set; }
        public DbSet<Order> oders { get; set; }
        public DbSet<Infoorder> infoorder { get; set; }
    }
}
