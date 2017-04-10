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
        /// <param name="isActive">Whether the users active, default value is true.</param>
        /// <returns></returns>
        public static UserEntity InsertUser(string username, string password, RoleTypeEnum roleType, bool isActive = true)
        {
            var salt = RNGCSP.GenerateRandomSalt();

            var user = new UserEntity()
            {
                Username = username,
                Password = PasswordHash.HashPassword(password, salt),
                Salt = Convert.ToBase64String(salt),
                IsActive = isActive,
                IsMarkedAsDeleted = false,
                DateCreated = DateTime.Now
            };
            
            user.Save();

            var userRole = new UserRoleEntity()
            {
                UserId = user.Id,
                RoleTypeEnum = (byte)roleType
            };
            
            userRole.Save();

            return user;
        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="roleType">The users role.</param>
        /// <param name="isActive">Whether the users active, default value is true.</param>
        /// <returns></returns>
        public static UserEntity UpdateUser(UserEntity user, RoleTypeEnum roleType, bool isActive = true)
        {
            if (user.UserRole.RoleTypeEnum != (byte)roleType)
            {
                user.UserRole.RoleTypeEnum = (byte)roleType;
                user.UserRole.Save();
            }

            user.IsActive = isActive;
            user.Save();

            return user;
        }

        public static void MarkUserAsDeleted()
        {
            // Won't be implemented untill the entire database is done.
            throw new NotImplementedException();
        }
    }
}
