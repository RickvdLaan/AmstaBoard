using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Extensions;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="roleType"></param>
        /// <param name="linkedActivities">IS NULL or IS NOT NULL</param>
        /// <returns></returns>
        public static UserActivityCollection GetAllActivitiesByCrudAndByRole(CrudTypeEnum crudType, RoleTypeEnum roleType, bool isNotNull)
        {
            Authentication.AuthenticateActivity("ReadUserActivity");
            Authentication.AuthenticateActivity("ReadUserRoleActivity");

            #region Query

            //SELECT  ua.Name
            //FROM    UserActivity AS ua
            //LEFT JOIN
            //UserRoleActivity ura
            //ON      ura.UserActivityName = ua.Name AND ura.RoleTypeEnum = @roleType
            //WHERE ura.UserActivityName IS NULL AND ua.Name LIKE '@crudType%';

            //SELECT  ua.Name
            //FROM    UserActivity AS ua
            //LEFT JOIN
            //        UserRoleActivity ura
            //ON      ura.UserActivityName = ua.Name AND ura.RoleTypeEnum = @roleType
            //WHERE ura.UserActivityName IS NOT NULL AND ua.Name LIKE '@crudType%';

            #endregion

            var userActivities = new UserActivityCollection();

            var filter = new PredicateExpression
            {
                UserActivityFields.Name == UserRoleActivityFields.UserActivityName
            };

            filter.AddWithAnd(UserRoleActivityFields.RoleTypeEnum == (byte)roleType);

            var bucket = new RelationPredicateBucket();
            var relation = bucket.Relations.Add(UserRoleActivityEntity.Relations.UserActivityEntityUsingUserActivityName, JoinHint.Right);
            relation.CustomFilter = filter;       

            if (isNotNull)
                bucket.PredicateExpression.Add(new PredicateExpression(UserRoleActivityFields.UserActivityName != DBNull.Value));
            else
                bucket.PredicateExpression.Add(new PredicateExpression(UserRoleActivityFields.UserActivityName == DBNull.Value));

            bucket.PredicateExpression.AddWithAnd(new FieldLikePredicate(UserActivityFields.Name, "{0}%".FormatString(crudType.Description())));

            userActivities.GetMulti(bucket.PredicateExpression, 0, null, bucket.Relations);

            return userActivities;
        }
    }
}
