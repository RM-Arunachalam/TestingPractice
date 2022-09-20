using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit.Abstractions;

namespace TestingPractice
{
    public class SeleniumBasics1
    {
        private readonly ITestOutputHelper output;

        public SeleniumBasics1(ITestOutputHelper output)
        {
            this.output = output;
        }
        [Fact]
        public void LaunchBrowser()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.cricbuzz.com");
            Console.WriteLine(driver.Title + " " + driver.Url);
        }

       // [Fact]
        public void testleapyear2000()
        {
            int num = 9;
            //output.WriteLine(LeapYear.CheckLeapYearOrNot(2000));
            //output.WriteLine(LeapYear.CheckLeapYearOrNot(1999));
           output.WriteLine(String.Format("The num is {0}",num));
        }

       // [Fact]
        public void testing2Methods()
        {
            Employee Arun = new Employee(15, "Arunachalam", "RM", "07-09-2020", "ASE", "Testing", 20000.89);
            output.WriteLine(Arun.method1());
            output.WriteLine(Arun.method2());

        }


       

    }
}