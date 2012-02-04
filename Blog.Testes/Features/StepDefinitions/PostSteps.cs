using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blog.Testes.Features.Support;
using Blog.WebApp.Models;
using FluentAssertions;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace Blog.Testes.Features.StepDefinitions
{
    [Binding]
    public class PostSteps
    {
        private Post post;
        private FirefoxDriver driver = Contexto.Driver;

        [Given(@"que eu tenho um post")]
        public void DadoQueEuTenhoUmPost()
        {
            using (var blogContext = new BlogContext())
            {
                foreach (var jaEraPost in blogContext.Posts)
                {
                    blogContext.Posts.Remove(jaEraPost);
                }
                post = new Post {Titulo = "Ola", Corpo = "Bem vindo", Data = new DateTime(2012, 2, 3), Autor = "Giovanni Bassi"};
                blogContext.Posts.Add(post);
                blogContext.SaveChanges();
            }
        }

        [When(@"eu vou na home do blog")]
        public void QuandoEuVouNaHomeDoBlog()
        {
            driver.Navigate().GoToUrl(@"http://localhost:3500/"); 
        }

        [Then(@"eu vejo o post")]
        public void EntaoEuVejoOPost()
        {
            driver.PageSource.Contains(post.Titulo).Should().BeTrue();
            driver.PageSource.Contains(post.Corpo).Should().BeTrue();
        }

    }
}
