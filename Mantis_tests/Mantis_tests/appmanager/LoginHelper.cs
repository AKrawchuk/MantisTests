using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Mantis_tests
{
    public class LoginHelper : HelperBase
    {
        public LoginHelper(ApplicationManager manager) : base(manager)
        {

        }

        public void Login(AccountData account)
        {
            Type(By.Id("username"), account.Name);
            //driver.FindElement(By.XPath("//*[@id='login - form']/fieldset/input[2]")).Click();
            driver.FindElement(By.CssSelector("input.btn")).Click();
            Type(By.Id("password"), account.Password);
            //driver.FindElement(By.XPath("//*[@id='login - form']/fieldset/input[3]")).Click();
            driver.FindElement(By.CssSelector("input.btn")).Click();
        }

        private void OpenMainPage()
        {
            manager.Driver.Url = "http://localhost/mantisbt-2.8.0/login_page.php";
        }
    }
}
