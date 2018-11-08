using security_example_basic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace security_example_basic.Repozitories
{
    public class SecurityDataContext: DbContext
    {
        public SecurityDataContext() : base("SecirityExampleConnection")
        {
            Database.SetInitializer<SecurityDataContext>(new InitializeWithDefaultUsers());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}