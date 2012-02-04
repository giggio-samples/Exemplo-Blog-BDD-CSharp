using SimpleBrowser;
using TechTalk.SpecFlow;

namespace Blog.Testes.Features.Support
{
    [Binding]
    public class HeadlessTag
    {
        [BeforeFeature("headless")]
        public static void StartBrowser()
        {
            Contexto.HeadlessDriver = new Browser();
        }
    }
}
