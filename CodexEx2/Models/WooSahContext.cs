using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace CodexEx2.Models
{

    public class TemporaryDbContextFactory : IDesignTimeDbContextFactory<WooSahContext>
    {
        //////// 
        public WooSahContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<WooSahContext>();
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            builder.UseSqlServer(configuration.GetConnectionString("Defa‌​ultConnection"));
            return new WooSahContext(builder.Options);
        }
    }
    public class WooSahContext : DbContext
    {
        public WooSahContext(DbContextOptions opts)
            : base(opts)
        { }

        public DbSet<ErrorViewModel  > ErrorViewModel { get; set; }
        public DbSet <WooSahPOCOModel> WooSahPocoModels { get; set; }    
    }
}


