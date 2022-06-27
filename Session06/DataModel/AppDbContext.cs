using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06.DataModel
{
    public class AppDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=.;initial catalog=140102ef;integrated security=True;multipleactiveresultsets=True;application name=Session06");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
