using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace commonmethod
{
    public class login : commmon_method
    
    {
        // #region object

        By sign_inbtn = By.XPath("//span[text()='Sign in']");
        By email = By.Id("//input[@id='CustomerEmail']");

        //#region construction

        public login(IWebDriver driver)
        {
            this.commondriver = (WebDriver)driver;
        }
        #region login
        public void clickLoginbutton()
        {
            Click(sign_inbtn);
        }

        //public void button



        #endregion

         void inputtext(  string eemail )
        {
            settext(email , eemail);
        }


    }
}
