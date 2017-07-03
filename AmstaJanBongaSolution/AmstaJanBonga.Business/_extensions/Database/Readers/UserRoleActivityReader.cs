using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class UserRoleActivityReader
    {
        public static UserRoleActivityEntity CreateUserRoleActivityEntity(RoleTypeEnum roleType, string userActivityName)
        {
            // Doesn't require a permission because it only creates an entity.

            var userRoleActivity = new UserRoleActivityEntity()
            {
                RoleTypeEnum = (byte)roleType,
                UserActivityName = userActivityName
            };

            return userRoleActivity;
        }

        public static UserRoleActivityCollection CreateUserRoleActivityEntityCollection(RoleTypeEnum roleType, params UserActivityCollection[] collections)
        {
            // Doesn't require a permission because it only creates an entity.
            
            var userRoleActivities = new UserRoleActivityCollection();

            foreach (var userActivityCollection in collections)
                foreach (var userActivity in userActivityCollection)
                    userRoleActivities.Add(CreateUserRoleActivityEntity(roleType, userActivity.Name));

            return userRoleActivities;
        }
    }
}
