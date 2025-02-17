﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JET2.Entities.User
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public User() { }

        public User(DataRow dr)
        {
            UserId = int.Parse(dr["UserId"].ToString());
            FirstName = dr["FirstName"].ToString();
            LastName = dr["LastName"].ToString();
            PhoneNumber = dr["PhoneNumber"].ToString();
            Email = dr["Email"].ToString();

        }
    }
}
