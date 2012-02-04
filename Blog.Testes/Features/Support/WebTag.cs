using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace Blog.Testes.Features.Support
{
    [Binding]
    public class WebTag
    {
        [BeforeFeature("firefox")]
        public static void StartBrowser()
        {
            Contexto.Driver = new FirefoxDriver();
        }

        [AfterFeature("firefox")]
        public static void StopBrowser()
        {
            if (Contexto.Driver != null)
            {
                Contexto.Driver.Dispose();
            }
        }

    }
}
