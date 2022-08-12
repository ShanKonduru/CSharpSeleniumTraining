using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

        [DataTestMethod]
        [DataRow ("USerName1", "Password1")]
        [DataRow ("USerName2", "Password2")]
        [DataRow ("USerName3", "Password3")]
        [DataRow ("USerName4", "Password4")]
        public void DataRowDrivenTestSeleniumMethod (string username, string password) {
            IWebDriver driver = new ChromeDriver ();
            driver.Navigate ().GoToUrl ("http://webdriveruniversity.com/Login-Portal/index.html?");
            IndexPage indexPage = new IndexPage (driver);
            indexPage.Login (username, password);
            // indexPage.Close ();
            }
        }
    }