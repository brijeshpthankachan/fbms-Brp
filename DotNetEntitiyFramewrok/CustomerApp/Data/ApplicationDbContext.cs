

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Data
{
    internal class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext()
        {

        }

        //overide onconfigure tab tab
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var conStr = @"Server=EXP;Database=EfCoreDb;Integrated Security=true;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(conStr);

        }

        public DbSet<Customers> Customer { get; set; }

    }
}

//  In Program Console
//  Add - Migration CreatePassengerTable
//  Update-Database
