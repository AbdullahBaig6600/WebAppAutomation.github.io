using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEB_AUTOMATION
{
    class SearchPage : CorePage
    {
        #region Locators
        By locationDropDown = By.Id("location");
        By hotelDropDown = By.Id("hotels");
        By roomTypeDropDown = By.Id("room_type");
        By noOfRoomDropDown = By.Id("room_nos");
        By checkInDateTxt = By.Id("datepick_in");
        By checkOutDateTxt = By.Id("datepick_out");
        By adultPerRoomDropDown = By.Id("adult_room");
        By childrenPerRoomDropDown = By.Id("child_room");
        By searchBtn = By.Id("Submit");
        By resetBtn = By.Id("Reset");
        #endregion

        public void SearchHotel()
        {
            driver.FindElement(locationDropDown).SendKeys("Sydney");
            driver.FindElement(hotelDropDown).SendKeys("Hotel Hervey");
            driver.FindElement(roomTypeDropDown).SendKeys("Standard");
            driver.FindElement(noOfRoomDropDown).SendKeys("2 - Two");
            driver.FindElement(checkInDateTxt).SendKeys("06/06/2023");
            driver.FindElement(checkOutDateTxt).SendKeys("07/06/2023");
            driver.FindElement(adultPerRoomDropDown).SendKeys("2 - Two");
            driver.FindElement(childrenPerRoomDropDown).SendKeys("2 - Two");
            driver.FindElement(searchBtn).Click();
        }

    }
}
