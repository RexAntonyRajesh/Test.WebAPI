﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain;

namespace Test.Service
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public RoleResponse RoleDetail { get; set; }
    }
    public class RoleResponse
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}
