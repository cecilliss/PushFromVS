using security_example_basic.Infrastructure;
using security_example_basic.Repozitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace security_example_basic.Filters.Authentication
{
    public class StaticUserManager
    {
        

        public static IPrincipal AuthenticateUser(string user, string pass)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var foundUser = db.UserRepository.Get(x => x.Email == user).FirstOrDefault();
                if (foundUser != null && foundUser.Password == CryptoHelper.CreatePasswordHash(pass,
                foundUser.Salt))
                {
                    return new StaticUser(user, new string[] { foundUser?.Role.Name });
                }
                return null;
            }
        }

    }
    
}