using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingPractice.Csharp_Aut._Framework_Dev.Helper;

namespace TestingPractice.Csharp_Aut._Framework_Dev.Pages
{
    public  class HomePageObjects:DriverHelper
    {
        IWebElement alink => driver.FindElement(By.LinkText("Login"));

        public void LoginButtonClick() => alink.Click();
    }
}
