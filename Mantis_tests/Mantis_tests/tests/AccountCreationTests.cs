using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using System.IO;

namespace Mantis_tests
{
    [TestFixture]
    public class AccountCreationTests : TestBase
    {
        [SetUp]
        public void setUpConfig()
        {
            app.Ftp.BackupFile("/config_defaults_inc.php");
            using (Stream localFile = File.Open("config_defaults_inc.php", FileMode.Open))
            {
                app.Ftp.Upload("/config_defaults_inc.php", localFile);
            }
        }

        [Test]
        public void TestAccountRegistration()
        {
            //AccountData account = new AccountData()
            //{
            //    Name = "testuser",
            //    Password = "password",
            //    Email = "testuser@Localhost.localdomain",
            //};

            //app.Registration.Register(account);
        }

        [TearDown]
        public void restoreConfig()
        {
            app.Ftp.RestoreBackupFile("/config_defaults_inc.php");
        }
    }
}
