using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_AUTOMATION
{
    class LoginPage : CorePage
    {
        By usernameTxt = By.Id("username");
        By passwordTxt = By.Id("password");
        By loginBtn = By.Id("login");

        public void Login(string url, string username, string password)
        {
            driver.Url = url;
            driver.FindElement(usernameTxt).SendKeys(username);
            driver.FindElement(passwordTxt).SendKeys(password);
            driver.FindElement(loginBtn).Click();
        }
    }
}
