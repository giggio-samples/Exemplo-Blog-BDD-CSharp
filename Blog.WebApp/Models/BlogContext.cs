using System.Data.Entity;

namespace Blog.WebApp.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() {}
        public BlogContext(string nameOrConnectionString) : base(nameOrConnectionString) {}
        public virtual DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
