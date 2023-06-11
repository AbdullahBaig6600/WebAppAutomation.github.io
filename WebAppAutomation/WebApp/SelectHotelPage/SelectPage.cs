using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_AUTOMATION
{
    class SelectPage : CorePage
    {
        #region Locators
        By selectRadioBtn = By.Id("radiobutton_0");
        By continueBtn = By.Id("continue");
        By cancelBtn = By.Id("cancel");
        #endregion

        public void SelectHotel()
        {
            driver.FindElement(selectRadioBtn).Click();
            driver.FindElement(continueBtn).Click();
        }

    }
}
