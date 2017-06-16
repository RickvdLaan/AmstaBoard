using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Extensions;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class UserActivityReader
    {
        public static UserActivityCollection GetAllActivitiesByCrud(CrudTypeEnum crudType)
        {
            Authentication.AuthenticateActivity("ReadUserActivity");

            var userActivities = new UserActivityCollection();

            var filter = new PredicateExpression
            {
                new FieldLikePredicate(UserActivityFields.Name, "{0}%".FormatString(crudType.Description()))
            };

            userActivities.GetMulti(filter, 0);

            return userActivities;
        }
    }
}
