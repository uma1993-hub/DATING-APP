﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.api.Models
{
    public class User

    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswoadHash { get; set;}
        public byte[] PasswordSalt { get; set; }

    }
}
