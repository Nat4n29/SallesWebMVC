using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SallesWebMvc.Models;

namespace SallesWebMvc.Data
{
    public class SallesWebMvcContext : DbContext
    {
        public SallesWebMvcContext (DbContextOptions<SallesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Departments> Departments { get; set; } = default!;
        public DbSet< SalesRecord> SalesRecords { get; set; }
        public DbSet<Seller> Seller { get; set; }
    }
}
