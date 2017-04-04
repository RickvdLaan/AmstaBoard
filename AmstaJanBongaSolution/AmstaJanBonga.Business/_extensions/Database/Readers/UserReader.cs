using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
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
        /// Gets the asked user, if exists.
        /// </summary>
        /// <param name="userId">Provide the unique user id.</param>
        /// <returns></returns>
        public static UserEntity GetUserById(int userId)
        {
            return new UserEntity(userId);
        }

        /// <summary>
        /// Gets the user which corresponds with the provided username and password.
        /// </summary>
        /// <param name="username">Provide the username.</param>
        /// <param name="password">Provide the plain text password.</param>
        /// <returns></returns>
        public static UserEntity GetUserByUsernameAndPassword(string username, string password)
        {
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
            var users = new UserCollection();
            users.GetMulti(null, 0);

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
            return new UserCollection().GetDbCount();
        }

        /// <summary>
        /// Determines whether the provided username is available.
        /// </summary>
        /// <param name="username">Provide the username.</param>
        /// <returns></returns>
        public static bool IsAvailableUsername(string username)
        {
            // Attempts to fetch the user based on the provided username.
            return new UserEntity().FetchUsingUCUsername(username);
        }

        /// <summary>
        /// Determines whether the provided user equals the specified role type.
        /// </summary>
        /// <param name="user">Provide the user entity.</param>
        /// <param name="roleTypes">Provide the role type.</param>
        /// <returns></returns>
        public static bool IsUserInRole(UserEntity user, params RoleTypeEnum[] roleTypes)
        {
            // Checks if the user exists and if the user is equal to any of the provided roletypes.
            return !user.IsNew && roleTypes.Any(roleType => user.UserRole.RoleTypeEnum == (short)roleType);
        }

        #endregion
    }
}
