using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using AmstaJanBonga.Business.Security;
using System;

namespace AmstaJanBonga.Business.Database.Managers
{
    public abstract class UserManager
    {
        /// <summary>
        /// Inserts a user into the database.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password in plain text.</param>
        /// <param name="roleType">The users role.</param>
        /// <returns></returns>
        public static UserEntity InsertUser(string username, string password, RoleTypeEnum roleType)
        {
            Authentication.AuthenticateActivity("");

            var salt = RNGCSP.GenerateRandomSalt();

            var user = new UserEntity()
            {
                RoleTypeEnum = (byte)roleType,
                Username = username,
                Password = PasswordHash.HashPassword(password, salt),
                Salt = Convert.ToBase64String(salt),
                IsMarkedAsDeleted = false,
                DateCreated = DateTime.Now
            };
            
            user.Save();

            return user;
        }

        /// <summary>
        /// Updates the provided users role.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="roleType"></param>
        /// <returns></returns>
        public static UserEntity UpdateUserRole(UserEntity user, RoleTypeEnum roleType)
        {
            Authentication.AuthenticateActivity("");

            if (user.RoleTypeEnum != (byte)roleType)
            {
                user.RoleTypeEnum = (byte)roleType;
            }

            user.Save();

            return user;
        }

        public static void MarkUserAsDeleted()
        {
            Authentication.AuthenticateActivity("");

            // Won't be implemented untill the entire database is done.
            throw new NotImplementedException();
        }
    }
}
