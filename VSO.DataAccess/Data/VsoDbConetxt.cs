using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSP.Models.AppModels;

namespace VSO.DataAccess.Data
{
    public class VsoDbConetxt: DbContext
    {
        public VsoDbConetxt(DbContextOptions<VsoDbConetxt> options):base(options) { }
        
        public DbSet<Customer> Customers { get; set; } 
        
        public DbSet<EmailAddress> EmailAddresses { get; set; }

        public DbSet<Address> Address { get; set; }
        
    }
}
