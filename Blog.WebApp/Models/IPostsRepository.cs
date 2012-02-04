using System.Collections.Generic;

namespace Blog.WebApp.Models
{
    public interface IPostsRepository
    {
        IEnumerable<Post> All();
    }
}