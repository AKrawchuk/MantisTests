using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Mantis_tests
{
    [TestFixture]
    public class ProjectCreationTest : AuthTestBase
    {
        [Test]
        public void TestProjectCreation()
        {
            ProjectData project = new ProjectData("Malkolm316");
            app.Project.Create(project);
            //AccountData account = new AccountData("administrator", "root");

            /*List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Create(group);

            Assert.AreEqual(oldGroups.Count + 1, app.Groups.GetGroupCount());

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);*/
        }
    }
}
