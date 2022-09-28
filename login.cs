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

        By sign_inbtn = By.XPath("//*[@id='shopify-section-header-men']/div/header/div/a[1]/span[1]");
        By email = By.XPath("//input[@id='CustomerEmail']");
        By passwrd = By.XPath("//input[@id='CustomerPassword']");
        
        //#region construction
        public login(IWebDriver driver)
        {
            commondriver = driver;
        }

    
 

        //public void button



       

         public void ForClick()
        {
            btn(sign_inbtn);
        }



        public void fortext(string username_email)
        {
            Settext(email , username_email);
        }

    }
}
