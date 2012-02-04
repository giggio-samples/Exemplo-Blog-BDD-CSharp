using System.Collections.Generic;
using System.Linq;

namespace Blog.WebApp.Models
{
    public class PostsRepository : IPostsRepository
    {
        private BlogContext context = new BlogContext();
        public IEnumerable<Post> All()
        {
            return context.Posts.ToList();
        }
    }
}