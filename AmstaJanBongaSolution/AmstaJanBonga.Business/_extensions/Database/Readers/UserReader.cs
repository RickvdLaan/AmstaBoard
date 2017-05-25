using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.HelperClasses;
using AmstaJanBonga.Business.Security;
using Rlaan.Toolkit.Extensions;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System;
using System.Diagnostics;
using System.Linq;

namespace AmstaJanBonga.Business.Database.Readers
{
    /// <summary>
    /// Class which contains methods to provide information about the user(s).
    /// </summary>
    public abstract class UserReader
    {
        #region Entities

        /// <summary>
        /// Gets the user with the corresponding user id or null. 
        /// </summary>
        /// <param name="userId">The users unique id.</param>
        /// <returns></returns>
        public static UserEntity GetUserById(int userId)
        {
            // Only needs to be checked when a user is already authenticated.
            // Reason being is that the user needs to be checked when 
            // logging in.
            if (Authentication.IsAuthenticated)
                Authentication.AuthenticateActivity("UserRead");

            return new UserEntity(userId);
        }

        /// <summary>
        /// Gets the user with the corresponding user id or null. 
        /// </summary>
        /// <param name="userId">The users unique id.</param>
        /// <param name="throwExceptionWhenNotFound"></param>
        /// <returns></returns>
        public static UserEntity GetUserById(int userId, bool throwExceptionWhenNotFound)
        {
            var user = GetUserById(userId);

            if (user.IsNew && throwExceptionWhenNotFound)
                throw new Exception("User not found for id {0}.".FormatString(userId));

            return user;
        }

        /// <summary>
        /// Gets the user which corresponds with the provided username and password.
        /// </summary>
        /// <param name="username">Provide the username.</param>
        /// <param name="password">Provide the plain text password.</param>
        /// <returns></returns>
        public static UserEntity GetUserByUsernameAndPassword(string username, string password)
        {
            // Does not require any permissions.

            var user = new UserEntity();
            user.FetchUsingUCUsername(username);
            
            if (!user.IsNew)
                if (user.IsValidPassword(password))
                    return user;

            return null;
        }

        #endregion

        #region Collections

        /// <summary>
        /// Returns a collection of all the users.
        /// </summary>
        /// <returns></returns>
        public static UserCollection GetAllUsers()
        {
            Authentication.AuthenticateActivity("UserRead");

            var users = new UserCollection();
            users.GetMulti(null, 0);

            return users;
        }

        public static UserCollection GetAllUnlinkedUsers()
        {
            Authentication.AuthenticateActivity("UserRead");

            var users = new UserCollection();
            var bucket = new RelationPredicateBucket() as IRelationPredicateBucket;
            
            // Relations
            bucket.Relations.Add(UserEntity.Relations.EmployeeEntityUsingUserId, JoinHint.Left)
                .CustomFilter = new PredicateExpression { EmployeeFields.UserId == UserFields.Id };

            // Predicate
            bucket.PredicateExpression.Add(EmployeeFields.UserId == DBNull.Value);

            // Sorting
            var sorter = new SortExpression
            {
                UserFields.Username | SortOperator.Ascending
            };

            users.GetMulti(bucket.PredicateExpression, -1, sorter, bucket.Relations);

            return users;
        }

        public static UserCollection GetAllUnlinkedUsers(int? includeUserId)
        {
            Authentication.AuthenticateActivity("UserRead");

            if (!includeUserId.HasValue)
                return GetAllUnlinkedUsers();

            var users = new UserCollection();
            var bucket = new RelationPredicateBucket() as IRelationPredicateBucket;

            // Relations
            bucket.Relations.Add(EmployeeEntity.Relations.UserEntityUsingUserId, JoinHint.Right);

            // Predicate
            bucket.PredicateExpression.Add(EmployeeFields.UserId == DBNull.Value);
            bucket.PredicateExpression.AddWithOr(EmployeeFields.UserId == includeUserId.Value);

            // Sorting
            var sorter = new SortExpression
            {
                UserFields.Username | SortOperator.Ascending
            };
            
            users.GetMulti(bucket.PredicateExpression, -1, sorter, bucket.Relations);

            return users;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns a database count for all the users.
        /// </summary>
        /// <returns></returns>
        public static int GetAllUsersDBCount()
        {
            Authentication.AuthenticateActivity("UserRead");

            return new UserCollection().GetDbCount();
        }

        /// <summary>
        /// Determines whether the provided username is available.
        /// </summary>
        /// <param name="username">Provide the username.</param>
        /// <returns></returns>
        public static bool IsAvailableUsername(string username)
        {
            Authentication.AuthenticateActivity("UserRead");

            // Attempts to fetch the user based on the provided username.
            return !(new UserEntity().FetchUsingUCUsername(username));
        }

        /// <summary>
        /// Determines whether the provided user equals the specified role type.
        /// </summary>
        /// <param name="user">Provide the user entity.</param>
        /// <param name="roleTypes">Provide the role type.</param>
        /// <returns></returns>
        public static bool IsUserInRole(UserEntity user, params RoleTypeEnum[] roleTypes)
        {
            // Role check does not require any permissions, getting the user needs permissions
            // or the user was obtained whilst attempting to log in.

            // Checks if the user exists and if the user is equal to any of the provided roletypes.
            return !user.IsNew && roleTypes.Any(roleType => user.UserRole.RoleTypeEnum == (short)roleType);
        }

        #endregion
    }
}
