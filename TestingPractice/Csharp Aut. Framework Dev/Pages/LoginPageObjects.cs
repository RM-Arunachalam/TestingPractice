using OpenQA.Selenium;
using TestingPractice.Csharp_Aut._Framework_Dev.Helper;

namespace TestingPractice.Csharp_Aut._Framework_Dev.Pages
{
    public class LoginPageObjects 
    {
        private IWebDriver _driver;
        public LoginPageObjects(IWebDriver driver)
        {
            _driver = driver;
        }
        IWebElement UserName => _driver.FindElement(By.Id("UserName"));
        IWebElement pwd => _driver.FindElement(By.Id("Password"));
        IWebElement LoginBtn => _driver.FindElement(By.CssSelector(".btn.btn-default"));

        IWebElement logoutBtn => _driver.FindElement(By.LinkText("Log off"));
        public void EnterUnameAndPwd(string Uname, String Password) {
            UserName.SendKeys(Uname);
            pwd.SendKeys(Password);         
}
        public void clickLogin() => LoginBtn.Click();

        public bool validateLogoutBtn() =>logoutBtn.Displayed;
      

        
    }
}
