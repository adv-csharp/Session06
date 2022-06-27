using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Session06.DataModel.config;
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
            var appSettings = Program.Configuration.GetSection("AppSettings").Get<AppSettings>();
            optionsBuilder.UseSqlServer(appSettings.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Reflection
            modelBuilder.ApplyConfiguration(new CountryConfig());
            modelBuilder.ApplyConfiguration(new ProvinceConfig());


            base.OnModelCreating(modelBuilder);

            var cfg = new MyConfig();
            cfg.Port(100)
            .ConnectionString("")
            .Host("")
            ;

        }

        
    }

    //Fluent API
    class MyConfig
    {
        string connectionString;
        int port;
        string host;

        public MyConfig ConnectionString(string connectionString)
        {
            this.connectionString = connectionString;
            return this;
        }

        public MyConfig Host(string host)
        {
            this.connectionString = host;
            return this;
        }

        public MyConfig Port(int port)
        {
            this.port = port;
            return this;
        }
    }


}
