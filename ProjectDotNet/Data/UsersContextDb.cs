using Microsoft.EntityFrameworkCore;
using ProjectDotNet.Models;

namespace ProjectDotNet.Data
{
    public class UsersContextDb : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<ForumThread> ForumThreads{ get; set; }
        public UsersContextDb(DbContextOptions options) :
       base(options){ }

    }
}
