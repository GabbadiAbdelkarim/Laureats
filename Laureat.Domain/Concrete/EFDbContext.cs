using Laureat.Domain.Entities;
using System.Data.Entity;

namespace Laureat.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
