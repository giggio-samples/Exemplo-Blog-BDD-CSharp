
using Blog.Testes.Features.Support;
using SimpleBrowser;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace Blog.Testes.Features.StepDefinitions
{
    [Binding]
    public class CommentStep
    {
        private readonly Browser driver = Contexto.HeadlessDriver;

        [When(@"eu vou na home do blog headless")]
        public void QuandoEuVouNaHomeDoBlogHeadless()
        {
            driver.Navigate(@"http://localhost:3500/");
        }

        [When(@"comento o post")]
        public void WhenComentoOPost()
        {
            driver.Find("author").Value = "comentador";
            driver.Find("body").Value = "corpo do comentario";
            driver.Find("input", FindBy.Value,"Comentar").Click();
        }
        [Then(@"o post fica comentado")]
        public void EntaoOPostFicaComentado()
        {
            //driver.ContainsText("comentador").Should().BeTrue();
            //driver.ContainsText("corpo do comentario").Should().BeTrue();
        }

    }
}
