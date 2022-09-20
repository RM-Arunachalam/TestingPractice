/*using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingPractice.Csharp_Aut._Framework_Dev.Helper;
using TestingPractice.Csharp_Aut._Framework_Dev.Pages;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Xunit.Abstractions;

namespace TestingPractice.Csharp_Aut._Framework_Dev.Tests
{
    public class LoginPageTest:DriverHelper
    {
        
        private readonly ChromeDriver chromeDriver;
        public LoginPageTest(ITestOutputHelper testOutputHelper)
        {
            testOutputHelper = testOutputHelper;
            //WebDriverManager
            driver =  new ChromeDriver();
        }
        [Fact]
        public void LoginTest()
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            testOutputHelper.WriteLine(driver.Url);
            HomePageObjects hp = new HomePageObjects();
            hp.LoginButtonClick();
            LoginPageObjects Lp = new LoginPageObjects();
            Lp.EnterUnameAndPwd("admin", "password");
            Lp.clickLogin();
            Assert.True(Lp.validateLogoutBtn());
            driver.Quit();


        }
    }
}
*/