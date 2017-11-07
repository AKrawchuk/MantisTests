using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantis_tests
{
    public class ProjectData
    {
        public ProjectData(string projectTitle)
        {
            ProjectTitle = projectTitle;
        }
        public string ProjectTitle { get; set; }
    }
}
