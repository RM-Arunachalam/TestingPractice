using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPractice.ReadDataFromTable
{
    public class Program:Base
    {
        public static void Main(string[] args)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/tables");
            new Utilities().ReadTable(driver.FindElement(By.XPath("//table[@id='table1']")));
            new Utilities().getCellData("Due", 3);
            new Utilities().getCellData("Email", 3);
        }
    }
}
