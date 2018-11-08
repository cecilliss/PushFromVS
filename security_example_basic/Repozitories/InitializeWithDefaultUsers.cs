using security_example_basic.Infrastructure;
using security_example_basic.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace security_example_basic.Repozitories
{
    public class InitializeWithDefaultUsers: DropCreateDatabaseAlways<SecurityDataContext>
    {
        protected override void Seed(SecurityDataContext context)
        {
            Role adminRole = new Role() { Name = "admins" };
            adminRole = context.Roles.Add(adminRole);
            var salt1 = CryptoHelper.GenerateRandomSalt(); 
            User u1 = new User();
            u1.FirstName = "Ivan";
            u1.LastName = "Vasiljevic";
            u1.Email = "ivan@example.com";
            u1.Password = CryptoHelper.CreatePasswordHash("pass", salt1);
            u1.Salt = salt1;
            u1.Role = adminRole;
            u1 = context.Users.Add(u1);
            var salt2 = CryptoHelper.GenerateRandomSalt();
            User u2 = new User();
            u2.FirstName = "Mladen";
            u2.LastName = "Kanostrevac";
            u2.Email = "mladen@example.com";
            u2.Password = CryptoHelper.CreatePasswordHash("pass", salt2);
            u2.Salt = salt2;
            u2.Role = adminRole;
            u2 = context.Users.Add(u2);
            context.SaveChanges();
        }
    }
}