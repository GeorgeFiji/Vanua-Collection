using Microsoft.EntityFrameworkCore;
using Vanua_Collective.Models;

namespace Vanua_Collective.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public required DbSet<Images> IMAGES { get; set; } 
        public required DbSet<Album> ALBUM { get; set; }
    }
}
