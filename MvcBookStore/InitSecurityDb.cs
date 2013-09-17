using MvcBookStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Security;
using WebMatrix.WebData;

namespace MvcBookStore
{
    public class InitSecurityDb : DropCreateDatabaseIfModelChanges<BSEntity>
    {
        protected override void Seed(BSEntity context)
        {

            WebSecurity.InitializeDatabaseConnection("ApplicationServices",
               "UserProfile", "UserId", "UserName", autoCreateTables: true);
            var roles = (SimpleRoleProvider)Roles.Provider;
            var membership = (SimpleMembershipProvider)Membership.Provider;

            if (!roles.RoleExists("Admin"))
            {
                roles.CreateRole("Admin");
            }
            if (membership.GetUser("hits", false) == null)
            {
                membership.CreateUserAndAccount("hits", "iamapot");
            }
            if (!roles.GetRolesForUser("hits").Contains("Admin"))
            {
                roles.AddUsersToRoles(new[] { "hits" }, new[] { "Admin" });
            }
        }
    }
}