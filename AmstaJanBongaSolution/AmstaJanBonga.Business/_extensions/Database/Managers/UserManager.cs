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
            var salt = RNGCSP.GenerateRandomSalt();

            var user = new UserEntity()
            {
                Username = username,
                Password = PasswordHash.HashPassword(password, salt),
                Salt = Convert.ToBase64String(salt),
                IsActive = true,
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
    }
}
