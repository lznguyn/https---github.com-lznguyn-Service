using Microsoft.EntityFrameworkCore;
using MuTraProAPI.Models;

namespace MuTraProAPI.Data
{
    public class MuTraProDbContext : DbContext
    {
        public MuTraProDbContext(DbContextOptions<MuTraProDbContext> options) : base(options) {}
        public DbSet<User> Users { get; set; }
    }
}
