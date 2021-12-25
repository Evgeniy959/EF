using System.IO;
using EF.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EF.Lib
{
    public sealed class DataBase : DbContext
    {
        public DbSet<Country> TabCountries { get; set; }

        private DataBase() { }

        public DataBase(DbContextOptions<DataBase> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        
        public static DataBase Init()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("connect_to_db_config.json");
            var connectionString = builder
                .Build()
                .GetConnectionString("DefaultConnection");
            
            var options = new DbContextOptionsBuilder<DataBase>()
                .UseMySQL(connectionString)
                .Options;
            
            return new DataBase(options);
        }
    }
}