using OpenQA.Selenium.Chrome;
using System.Reflection;
using TechTalk.SpecFlow;
using TestingPractice.Csharp_Aut._Framework_Dev.Helper;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace TestingPractice.Csharp_Aut._Framework_Dev.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        private DriverHelper _drh;
        public Hooks1(DriverHelper drh)
        {
            _drh = drh;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            options.AddArgument("*--disable-gpu");
            options.AddArgument("--headless");
            //new DriverManager().SetUpDriver(new ChromeConfig());

            _drh.driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),options);

        }
        [AfterScenario]
        public void AfterScenario()
        {
            _drh.driver.Dispose();
        }
    }
}
