using System.Collections.Generic;
using System.Web.Mvc;
using Blog.WebApp.Controllers;
using Blog.WebApp.Models;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace Blog.Testes.Specs.Controller
{
    [TestFixture]
    public class HomeIndexSpec
    {
        private HomeController controller;
        private ActionResult result;
        private IList<Post> posts = new List<Post>();

        [SetUp]
        public void Index()
        {
            var repository = new Mock<IPostsRepository>();
            repository.Setup(c => c.All()).Returns(posts);
            controller = new HomeController(repository.Object);
            result = controller.Index();
        }
        [Test]
        public void SendsPostsToView()
        {
            ((ViewResult) result).Model.Should().Be(posts);
        }
    }
}
