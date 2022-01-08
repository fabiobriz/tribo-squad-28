using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Tribo.Data
{
    public class TriboDbContext : IdentityDbContext
    {
        public TriboDbContext(DbContextOptions<TriboDbContext> options)
            : base(options)
        {
        }
    }
}