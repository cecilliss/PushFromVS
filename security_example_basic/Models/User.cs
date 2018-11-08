﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace security_example_basic.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual Role Role { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        [JsonIgnore]
        public byte[] Salt { get; set; }
    }
}