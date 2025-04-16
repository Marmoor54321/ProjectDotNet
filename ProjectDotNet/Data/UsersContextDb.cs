using Microsoft.EntityFrameworkCore;
using ProjectDotNet.Models;

namespace ProjectDotNet.Data
{
    public class UsersContextDb : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<ForumThread> ForumThreads{ get; set; }
        public DbSet<Post> Posts { get; set; }
        public UsersContextDb(DbContextOptions options) :
       base(options){ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Post>()
        .HasOne(p => p.User)
        .WithMany(u => u.Posts)
        .HasForeignKey(p => p.UserId)
        .OnDelete(DeleteBehavior.Restrict);

    modelBuilder.Entity<ForumThread>()
        .HasOne(t => t.User)
        .WithMany(u => u.ForumThreads)
        .HasForeignKey(t => t.UserId)
        .OnDelete(DeleteBehavior.Cascade);

    modelBuilder.Entity<Post>()
        .HasOne(p => p.ForumThread)
        .WithMany(t => t.Posts)
        .HasForeignKey(p => p.ForumThreadId)
        .OnDelete(DeleteBehavior.Cascade);
}
    }

}
