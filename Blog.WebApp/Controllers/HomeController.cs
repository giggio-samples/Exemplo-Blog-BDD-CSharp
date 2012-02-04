using System.Web.Mvc;
using Blog.WebApp.Models;

namespace Blog.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostsRepository postsRepository;

        public HomeController(IPostsRepository postsRepository)
        {
            this.postsRepository = postsRepository;
        }

        public ActionResult Index()
        {
            var posts = postsRepository.All();
            return View(posts);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
