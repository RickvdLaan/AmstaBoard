using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Security;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class UserRoleActivityManager
    {
        public static void UpdateMulti(UserRoleActivityCollection originalCollection, UserRoleActivityCollection newCollection)
        {
            Authentication.AuthenticateActivity("UpdateUserRoleActivity");

            var tracker = new UserRoleActivityCollection();
            originalCollection.RemovedEntitiesTracker = tracker;

            originalCollection.RemovedEntitiesTracker.AddRange(originalCollection);
            originalCollection.AddRange(newCollection);
            originalCollection.RemovedEntitiesTracker.DeleteMulti();

            newCollection.SaveMulti();
        }
    }
}
