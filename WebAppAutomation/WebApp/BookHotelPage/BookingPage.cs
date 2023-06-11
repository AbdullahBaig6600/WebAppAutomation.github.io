using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_AUTOMATION
{
    class BookingPage : CorePage
    {
        #region Locators
        By fnameTxt = By.Id("first_name");
        By lnameTxt = By.Id("last_name");
        By addressTxt = By.Id("address");
        By cCNoTxt = By.Id("cc_num");
        By cCTypeDropDown = By.Id("cc_type");
        By expiryMonthDropDown = By.Id("cc_exp_month");
        By expiryYearDropDown = By.Id("cc_exp_year");
        By cVVNoTxt = By.Id("cc_cvv");
        By bookNowBtn = By.Id("book_now");
        By cancelBtn = By.Id("cancel");
        #endregion

        public void BookHotel()
        {
            driver.FindElement(fnameTxt).SendKeys("Abdullah");
            driver.FindElement(lnameTxt).SendKeys("Baig");
            driver.FindElement(addressTxt).SendKeys("R1-111/2, My Address, Demo Area, Town");
            driver.FindElement(cCNoTxt).SendKeys("12345678987654321");
            driver.FindElement(cCTypeDropDown).SendKeys("VISA");
            driver.FindElement(expiryMonthDropDown).SendKeys("December");
            driver.FindElement(expiryYearDropDown).SendKeys("2023");
            driver.FindElement(cVVNoTxt).SendKeys("1234");

            driver.FindElement(bookNowBtn).Click();
        }

    }
}
