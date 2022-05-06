using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace Target_Appliaction
{

    class SearchingJob
    {
        public SearchingJob()
        {
            PageFactory.InitElements(MarsFramework.Global.GlobalDefinitions.driver, this);
        }

        #region 
       

        [FindsBy(How = How.CssSelector, Using = ".YYNH1ZE[data-analytics='job search']")]
        private IWebElement JobSearchTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#keywords-input")]
        private IWebElement WhatBar { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#SearchBar__Where")]
        private IWebElement WhereBar { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".yvsb870.yvsb877._14uh9945y._14uh994p._14uh9945a._14uh9944u._14uh994y._14uh994x._14uh9945._14uh994g2._14uh9944._14uh994h._3un8550._3un8555._1qw3t4i15._1qw3t4i17._14uh99416._14uh99417")]
        private IWebElement SeekTab { get; set; }

        [FindsBy(How = How.CssSelector, Using = "span[class='yvsb870 _14uh9944']")]
        private IWebElement ProfileName { get; set; }


        #endregion
        internal void SearchJob()
        {
            GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.CssSelector(".YYNH1ZE[data-analytics='job search']"), 10);
            
            JobSearchTab.Click();
            Thread.Sleep(2000);
            WhatBar.Click();
            Thread.Sleep(2000);
            WhatBar.SendKeys("Software Tester");
            Thread.Sleep(2000);
            WhereBar.Click();
           
            WhereBar.SendKeys("Sydney NSW 2000");
            Thread.Sleep(2000);
            SeekTab.Click();
            Thread.Sleep(2000);

            String actualMessage = ProfileName.Text;
            String expectedMessage = "Venky";


            GlobalDefinitions.VerifySuccessfulMessage(expectedMessage, actualMessage, "Search Job");
        }
    }
}