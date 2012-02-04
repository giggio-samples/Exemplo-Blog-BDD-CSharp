using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.WebApp.Models;

namespace Blog.WebApp.Controllers
{ 
    public class CommentsController : Controller
    {
        private readonly ICommentsRepository commentsRepository;
        private BlogContext db = new BlogContext();

        public CommentsController(ICommentsRepository commentsRepository)
        {
            this.commentsRepository = commentsRepository;
        }

        [HttpPost]
        public ActionResult Create(Comment comment)
        {
            commentsRepository.Save(comment);
            return RedirectToAction("Index", "Home");  
        }
    }
}