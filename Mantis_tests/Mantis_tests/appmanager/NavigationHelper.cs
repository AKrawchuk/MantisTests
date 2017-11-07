using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace Mantis_tests
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL)
            : base(manager)
        {
            this.baseURL = baseURL;
        }

        public void OpenHomePage()
        {
            if (driver.Url == baseURL + "mantisbt-2.8.0/")
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL + "mantisbt-2.8.0/");
        }

        public void GoToManagePage()
        {
            //if (driver.Url == baseURL + "mantisbt-2.8.0/manage_overview_page.php")
            //{
            //    return;
            //}
            //driver.FindElement(By.ClassName("menu-text")).Click();
            driver.FindElements(By.ClassName("menu-text")).Click();
        }

        public void GoToManageProjectsPage()
        {
            if (driver.Url == baseURL + "mantisbt-2.8.0/manage_proj_page.php")
            {
                return;
            }
            driver.FindElement(By.LinkText("Manage Projects")).Click(); 
        }
    }
}

