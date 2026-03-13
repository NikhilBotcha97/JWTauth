using JWTauth.Entities;
using Microsoft.EntityFrameworkCore;

namespace JWTauth.Data
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext (options)
    {
        public DbSet<User> Users { get; set; }
    }
}
