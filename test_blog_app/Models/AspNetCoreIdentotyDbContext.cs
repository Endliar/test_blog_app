using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace test_blog_app.Models
{
    public class AspNetCoreIdentotyDbContext : IdentityDbContext
    {
        public AspNetCoreIdentotyDbContext(DbContextOptions<AspNetCoreIdentotyDbContext> options) : base(options) 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
