using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V102.DOM;

namespace commonmethod
{

    public class commmon_method
    {

        public IWebDriver commondriver;
        Actions actions ;



        //Find Element 

        public IWebElement FindElement(By Locate)
        {
            return commondriver.FindElement(Locate);
        }


        //Set Text In Element
        public void Settext(By locate,string text)
           
       {
            IWebElement findedelement1 = FindElement(locate);
            findedelement1.SendKeys(text + Keys.Tab);

        
        }

        public void btn(By locate)
        {
            actions = new Actions(commondriver);
            actions.Click(FindElement(locate)).Build().Perform();
        
        }



    }
}