using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;

namespace Solid.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> UserList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
        }

    }
}