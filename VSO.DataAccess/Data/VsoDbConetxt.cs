using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using VSP.Models.AppModels;

namespace VSO.DataAccess.Data
{
    public class VsoDbConetxt: IdentityDbContext
    {
        public VsoDbConetxt(DbContextOptions<VsoDbConetxt> options):base(options) { }
        
        public DbSet<Customer> Customers { get; set; } 
        
        public DbSet<EmailAddress> EmailAddresses { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectItem> ProjectItems { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(b => b.CreatedDate)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Customer>()
                .Property(b => b.UpdatedDate)
                .HasDefaultValueSql("getdate()");

            base.OnModelCreating(modelBuilder);
        }

    }
}
