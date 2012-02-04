using System.Diagnostics;
using NUnit.Framework;

namespace Blog.Testes
{
    [SetUpFixture]
    class Bootstrap
    {
        private Process process;

        [SetUp]
        public void SobeApp()
        {
            StartWebProcess();
            ResetDb();
        }

        private static void ResetDb()
        {
            System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseAlways<WebApp.Models.BlogContext>());
        }

        private void StartWebProcess()
        {
            var si = new ProcessStartInfo(@"C:\Program Files (x86)\Common Files\Microsoft Shared\DevServer\10.0\WebDev.WebServer40.exe", @"/port:3500 /nodirlist /path:""C:\proj\src\rabiscos\tdd3\Blog\Blog.WebApp"" /vpath:""/""");
            process = new Process {StartInfo = si};
            process.Start();
        }

        [TearDown]
        public void Teardown()
        {
            process.Kill();
        }
    }
}
