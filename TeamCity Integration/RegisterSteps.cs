using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium;

namespace TeamCity_Integration
{
    [Binding]
    public  class RegisterSteps
    {
        IWebDriver driver;
        RegisterClass registerClass = new RegisterClass();

        [Given(@"I browse to the toolqa app")]
        public void GivenIBrowseToTheToolqaApp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://demoqa.com/registration/");
            driver.Manage().Window.Maximize();
        }

        [When(@"Enter all details")]
        public void WhenEnterAllDetails()
        {
            registerClass.FillRegisterForm(driver);
        }

        [Then(@"User should be able to register in toolsqa app successfully")]
        public void ThenUserShouldBeAbleToRegisterInToolsqaAppSuccessfully()
        {

            registerClass.ClickOnSubmitButton(driver);

            string msg = "Thank you for your registration";
            string actmsg = registerClass.GetMessage(driver);
            Assert.AreEqual(msg, actmsg);
        }

    }
}
