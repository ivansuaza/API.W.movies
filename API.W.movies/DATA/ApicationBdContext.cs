using API.W.movies.DATA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace API.W.movies.DATA
{
    public class ApicationBdContext : DbContext
    {
        public ApicationBdContext(DbContextOptions<ApicationBdContext>options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
