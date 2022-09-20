using System;
using TechTalk.SpecFlow;
using TestingPractice.Csharp_Aut._Framework_Dev.Helper;
using TestingPractice.Csharp_Aut._Framework_Dev.Pages;

namespace TestingPractice
{
    [Binding]
    public class LoginFeatureStepDefinitions
    {
        private DriverHelper _dh;
        HomePageObjects hp;
        LoginPageObjects Lp;
        public LoginFeatureStepDefinitions(DriverHelper dh)
        {
            _dh = dh;
             hp = new HomePageObjects(_dh.driver);
             Lp = new LoginPageObjects(_dh.driver);
        }

       

        [Given(@"Login to the  Application")]
        public void GivenLoginToTheApplication()
        {
            //testOutputHelper.WriteLine("starting tests");
            _dh.driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            //testOutputHelper.WriteLine(driver.Url);
        }

        [Given(@"I click on  Login Link")]
        public void GivenIClickOnLoginLink()
        {
            hp.LoginButtonClick();
           
        }

        [When(@"user enters username and pwd")]
        public void EnterCred()
        {
            Lp.EnterUnameAndPwd("admin", "password");
           
        }

        [When(@"user clicks the  submit")]
        public void WhenUserClicksTheSubmit()
        {
            Lp.clickLogin();
        }

        [Then(@"it should navigates to the login page")]
        public void ThenItShouldNavigatesToTheLoginPage()
        {
            Assert.True(Lp.validateLogoutBtn());
        }
    }
}
