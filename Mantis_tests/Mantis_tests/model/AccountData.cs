﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantis_tests
{
    public class AccountData
    {
        public AccountData(string userName, string password)
        {
            Name = userName;
            Password = password;
        }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email{ get; set; }
    }
}
