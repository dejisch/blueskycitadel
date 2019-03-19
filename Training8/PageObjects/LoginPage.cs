using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training8.Utilities;

namespace Training8.PageObjects
{
    public class LoginPage
    {
        //driver.FindElement(By.LinkText("Login")
        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement login;

        [FindsBy(How = How.XPath, Using = "//*[@id='login-form']/div[1]")]
        private IWebElement loginErrorMsg;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailElement;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement passwordElement;

        [FindsBy(How = How.CssSelector, Using = "#login-form > div.buttons-holder.text-center > button")]
        private IWebElement signin;

        public LoginPage()
        {

            PageFactory.InitElements(Hooks.driver, this);
        }

        public bool IsloginErrorMsgDisplayed()
        {
            return loginErrorMsg.Displayed;
        }

        public void ClickSignin()
        {
            signin.Click();
        }

        public void TypePassword()
        {
            passwordElement.SendKeys("myPasswordisSecure");
        }


        public void TypeEmail()
        {
            emailElement.SendKeys("test@test.com");
        }

        public void ClickLogin()
        {
            login.Click();
        }

    }
}
