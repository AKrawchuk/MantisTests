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
    public class ProjectHelper : HelperBase
    {
        public ProjectHelper(ApplicationManager manager) : base(manager)
        {

        }

        public ProjectHelper Create(ProjectData project)
        {
            manager.Navigator.GoToManagePage();
            manager.Navigator.GoToManageProjectsPage(); 
            return this;
        }
    }
}
