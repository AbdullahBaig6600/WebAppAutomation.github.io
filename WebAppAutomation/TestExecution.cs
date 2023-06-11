using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;

namespace WEB_AUTOMATION
{
    [TestClass]
    public class TestExecution
    {
        #region Setups and Cleanups

        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {

        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {

        }

        [TestInitialize()]
        public void TestInit()
        {
            CorePage.SeleniumInit(ConfigurationManager.AppSettings["Browser"].ToString());
        }
        
        [TestCleanup()]
        public void TestCleanup()
        {
            CorePage.driver.Close();
        }
        #endregion

        LoginPage loginPage = new LoginPage();
        SearchPage searchPage = new SearchPage();
        SelectPage selectPage = new SelectPage();
        BookingPage bookingPage = new BookingPage();

        [TestMethod]
        public void LoginWithValidUserValidPassword_TC001()
        {
            
            loginPage.Login("https://adactinhotelapp.com/", "baigxo12345", "baigxo12345");
            string actuaText = CorePage.driver.FindElement(By.ClassName("welcome_menu")).Text;
            Assert.AreEqual("Welcome to Adactin Group of Hotels", actuaText);
            
        }

        [TestMethod]
        public void LoginWithInalidUserInvalidPassword_TC002()
        {
            loginPage.Login("https://adactinhotelapp.com/", "baigxo", "baigxo");
            string actuaText = CorePage.driver.FindElement(By.ClassName("auth_error")).Text;
            Assert.AreEqual("Invalid Login details or Your Password might have expired. Click here to reset your password", actuaText);
        }

        [TestMethod]
        public void SearchHotel_TC001()
        {
            loginPage.Login("https://adactinhotelapp.com/", "baigxo12345", "baigxo12345");
            searchPage.SearchHotel();
        }

        [TestMethod]
        public void SelectHotel_TC001()
        {
            loginPage.Login("https://adactinhotelapp.com/", "baigxo12345", "baigxo12345");
            searchPage.SearchHotel();
            selectPage.SelectHotel();
        }

        [TestMethod]
        [TestCategory("BookHotel")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Data.xml", "BookHotel_TC001", DataAccessMethod.Sequential)]
        public void BookHotel_TC001()
        {
            string url = TestContext.DataRow["url"].ToString();
            string user = TestContext.DataRow["username"].ToString();
            string pass = TestContext.DataRow["password"].ToString();

            loginPage.Login(url, user, pass); ;
            searchPage.SearchHotel();
            selectPage.SelectHotel();
            bookingPage.BookHotel();
        }
    }
}
