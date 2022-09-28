using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commonmethod
{
    // [TestClass]
    public class commmon_method
    {

        public WebDriver commondriver;
        Actions action;


      

        #region     frequent_method

        //find element
        public IWebElement findElement(By Locate)
        {
            return commondriver.FindElement(Locate);
        }

        //send text in input field
        public void settext(By locate, string text)
        {
            IWebElement findEleement = findElement(locate);
            findEleement.Clear();
            //removetext(findelement);


            findEleement.SendKeys(text + Keys.Tab);


        }

        //click on the element

        public void Click(By locator)

        {
            action = new Actions(commondriver);
            action.Click(findElement(locator)).Build().Perform();
        }

        //remove text
        public void removetext(IWebElement element)
        {
            int a = element.Text.Length;
            while (a > 0)
            { 
            element.SendKeys(Keys.Backspace);
            }
        
        }









        //[TestMethod]
        //public void TestMethod1()
        //{

        //}
        #endregion
    }
}