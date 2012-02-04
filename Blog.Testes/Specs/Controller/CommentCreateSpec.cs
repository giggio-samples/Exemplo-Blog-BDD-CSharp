using System.Web.Mvc;
using Blog.WebApp.Controllers;
using Blog.WebApp.Models;
using Moq;
using NUnit.Framework;
using FluentAssertions;

namespace Blog.Testes.Specs.Controller
{
    [TestFixture]
    public class CommentCreateSpec
    {
        private CommentsController controller;
        private ActionResult result;
        private Comment comment = new Comment{Author = "a", Body = "b"};
        private Mock<ICommentsRepository> repository;

        [SetUp]
        public void CreateController()
        {
            repository = new Mock<ICommentsRepository>();
            controller = new CommentsController(repository.Object);
            result = controller.Create(comment);
        }
        [Test]
        public void CreatesComment()
        {
            repository.Verify(r => r.Save(comment), Times.Once());
        }
        [Test]
        public void RedirectsToHome()
        {
            ((RedirectToRouteResult) result).RouteValues["controller"].Should().Be("Home");
        }
    }
}
