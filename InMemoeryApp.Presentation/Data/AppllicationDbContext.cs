using InMemoeryApp.Presentation.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace InMemoeryApp.Presentation.Data
{
    public class AppllicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppllicationDbContext(DbContextOptions<AppllicationDbContext> options) : base(options)
        {

        }
    }
}
