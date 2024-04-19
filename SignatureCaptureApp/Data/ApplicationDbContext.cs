using Microsoft.EntityFrameworkCore;
using SignatureCaptureApp.Models;

namespace SignatureCaptureApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions) : base(contextOptions)
        { }
        public DbSet<Account>Accounts{ get; set; }
    }
}
