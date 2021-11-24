using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BookListRazor.Models
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }

    }
}
