using Microsoft.EntityFrameworkCore;

namespace Goraku.Web
{
    public class GorakuContext : DbContext
    {
        public GorakuContext(DbContextOptions<GorakuContext> options)
            : base(options)
        { }
    }
}