using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;


namespace MarsFramework.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "(//a[@class='u4tdkuW'][normalize-space()='Sign in'])[1]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.CssSelector, Using = "#emailAddress")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.CssSelector, Using = "#password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.CssSelector, Using = "button[type='submit']")]
        private IWebElement LoginBtn { get; set; }

        #endregion

        internal void LoginSteps()
        {
            GlobalDefinitions.NavigateUrl();
            Thread.Sleep(5000);

            SignIntab.Click();
            Thread.Sleep(5000);
            Email.SendKeys("hi.its.venky@gmail.com");
            Thread.Sleep(5000);
            Password.SendKeys("Im@seek4");
            Thread.Sleep(5000);
            LoginBtn.Click();
            Thread.Sleep(5000);
        }
    }
}