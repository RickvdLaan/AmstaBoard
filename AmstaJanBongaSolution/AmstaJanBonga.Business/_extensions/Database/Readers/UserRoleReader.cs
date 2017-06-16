using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Security;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class UserRoleReader
    {
        public static UserRoleCollection GetAllUserRoles()
        {
            Authentication.AuthenticateActivity("ReadUserRole");

            var userRoles = new UserRoleCollection();
            userRoles.GetMulti(null, 0);
            
            return userRoles;
        }
    }
}
