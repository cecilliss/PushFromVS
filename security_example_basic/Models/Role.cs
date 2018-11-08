﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace security_example_basic.Models
{
    public class Role
    {

        public Role()
        {
            Users = new HashSet<User>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<User> Users { get; set; }

    }
}