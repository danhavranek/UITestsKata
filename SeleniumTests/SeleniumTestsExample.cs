using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    public class SeleniumTestsExample
    {
        IWebDriver? driver;

        [SetUp]
        public void startBrowser()
        {
            // TODO: Place here path to you chrome driver
            driver = new ChromeDriver("");
        }

        [Test]
        public void OrderProcessTest()
        {
            driver.Url = "https://www.saucedemo.com";

            var userNameInput = driver.FindElement(By.Id("user-name"));
            var passwordInput = driver.FindElement(By.Id("password"));
            var loginButton = driver.FindElement(By.Id("login-button"));
            
            userNameInput.SendKeys("standard_user");
            passwordInput.SendKeys("secret_sauce");
            loginButton.Click();

            Assert.AreEqual("https://www.saucedemo.com/inventory.html", driver.Url);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }

}