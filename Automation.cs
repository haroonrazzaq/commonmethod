﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace commonmethod
{
    [TestClass]
    public class Automation
    {
        [TestMethod]
        public void loginbutton()
        {
            IWebDriver adriver = new ChromeDriver();
            adriver.Manage().Window.Maximize();
            adriver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(60);
            adriver.Url =" https://www.beyondeast.com/pages/women";
            login Ol = new login(adriver);
            Ol.clickLoginbutton();
            inputtext

        }

    }
}
