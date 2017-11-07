using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Mantis_tests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper navHelper;
        protected ProjectHelper projectHelper;

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"C:\\Program Files\\Mozilla Firefox_ESR\\firefox.exe";
            options.UseLegacyImplementation = true;
            driver = new FirefoxDriver(options);

            baseURL = "http://localhost/";
            //baseURL = "http://localhost/mantisbt-2.8.0/"; 
            Registration = new RegistrationHelper(this);
            Ftp = new FtpHelper(this);

            loginHelper = new LoginHelper(this);
            navHelper = new NavigationHelper(this, baseURL);
            projectHelper = new ProjectHelper(this);
        }

        ~ApplicationManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public static ApplicationManager GetInstance()
        {
            if (!app.IsValueCreated)
            {
                ApplicationManager newInstance = new ApplicationManager();
                newInstance.driver.Url = "http://localhost/mantisbt-2.8.0/login_page.php";
                app.Value = newInstance;
            }
            return app.Value;
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public RegistrationHelper Registration { get; private set; }
        public FtpHelper Ftp { get; private set; }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }
        public NavigationHelper Navigator
        {
            get
            {
                return navHelper;
            }
        }

        public ProjectHelper Project
        {
            get
            {
                return projectHelper;
            }
        }
    }
}
