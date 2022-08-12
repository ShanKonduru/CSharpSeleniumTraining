using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumUnitTest {
    [TestClass]
    public class IndexPageUnitTest {
        [TestMethod]
        public void TestMethod1 () {
            IWebDriver driver = new ChromeDriver ();
            driver.Navigate ().GoToUrl ("http://webdriveruniversity.com/Login-Portal/index.html?");
            IndexPage indexPage = new IndexPage (driver);
            indexPage.Login ("username", "passwprd");
            // indexPage.Close ();
        }
    }
}