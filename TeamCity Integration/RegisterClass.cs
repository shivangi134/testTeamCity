using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;



namespace TeamCity_Integration
{
    public class RegisterClass
    {

        #region ElementLocator

        private By RegistrationLocator = By.CssSelector("entry-title");
        private By FirstNameLocator = By.Name("first_name");
        private By LastNameLocator = By.Name("last_name");
        private By MaritalStatusLocator = By.XPath("//input[@value='single']");
        private By HobbyLocator = By.XPath("//input[@value='dance']");
        private By countryLocator = By.XPath("//select[@id='dropdown_7']/option[text()='Afghanistan']");
        private By PhoneNumberLocator = By.XPath("//input[@class='input_fields  piereg_validate[required,custom[phone_international]]']");
        private By UserNameLocator = By.XPath("//input[@id='username']");
        private By EmailLocator = By.XPath("//input[@id='email_1']");
        private By PasswordLocator = By.XPath("//input[@name='password']");
        private By ConfirmPasswordLocator = By.XPath("//input[@id='confirm_password_password_2']");
        private By SubmitButtonLocator = By.XPath("//input[@type='submit']");
        private By RegisterSuccessfullyMessageLocator = By.CssSelector(".piereg_message");

        #endregion

        public void FillRegisterForm(IWebDriver driver)
        {
            driver.FindElement(FirstNameLocator).SendKeys("test");
            driver.FindElement(LastNameLocator).SendKeys("test");
            driver.FindElement(MaritalStatusLocator).Click();
            driver.FindElement(HobbyLocator).Click();
            driver.FindElement(countryLocator);
            driver.FindElement(PhoneNumberLocator).SendKeys("9834567890");
            driver.FindElement(UserNameLocator).SendKeys("SoniaSharma");
            driver.FindElement(EmailLocator).SendKeys("test066@gmail.com");
            driver.FindElement(PasswordLocator).SendKeys("Test@123");
            driver.FindElement(ConfirmPasswordLocator).SendKeys("Test@123");

        }

        public void ClickOnSubmitButton(IWebDriver driver)
        {
            driver.FindElement(SubmitButtonLocator).Click();
        }

        public string GetMessage(IWebDriver driver)
        {
            return driver.FindElement(RegisterSuccessfullyMessageLocator).Text;
        }
    }
}
