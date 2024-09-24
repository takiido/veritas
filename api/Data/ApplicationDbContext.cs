using api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Word> Words { get; set; }
        public DbSet<Vocabulary> Vocabularies { get; set; }
    }
}
