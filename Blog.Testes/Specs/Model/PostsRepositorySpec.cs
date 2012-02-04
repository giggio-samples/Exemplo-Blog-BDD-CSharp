using System;
using System.Linq;
using Blog.WebApp.Models;
using FluentAssertions;
using NUnit.Framework;

namespace Blog.Testes.Specs.Model
{
    [TestFixture]
    public class PostsRepositorySpec
    {
        private PostsRepository repository;

        [SetUp]
        public void CreateRepository()
        {
            using (var context = new BlogContext())
            {
                foreach (var post in context.Posts)
                {
                    context.Posts.Remove(post);
                }
                context.Posts.Add(new Post {Titulo = "Ola!", Corpo = "Bem vindo!", Data = new DateTime(2012, 2, 3), Autor = "Giovanni Bassi"});
                context.Posts.Add(new Post {Titulo = "Ola 2!", Corpo = "Bem vindo 2!", Data = new DateTime(2011, 2, 3), Autor = "Victor Cavalcante"});
                context.SaveChanges();
            }
            repository = new PostsRepository();
        }
        [Test]
        public void All()
        {
            var posts = repository.All();
            posts.Count().Should().Be(2);
        }
    }

}
