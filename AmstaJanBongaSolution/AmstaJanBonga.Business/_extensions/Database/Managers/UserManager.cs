using AmstaJanBonga.Business.Database.Readers;
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
            Authentication.AuthenticateActivity("CreateUser");

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
            Authentication.AuthenticateActivity("UpdateUser");

            if (user.RoleTypeEnum != (byte)roleType)
            {
                user.RoleTypeEnum = (byte)roleType;
            }

            user.Save();

            return user;
        }

        public static void UpdatePassword(UserEntity user, string password)
        {
            user.Password = PasswordHash.HashPassword(password, Convert.FromBase64String(user.Salt));

            user.Save();
        }

        public static void MarkUserAsDeleted(UserEntity user)
        {
            Authentication.AuthenticateActivity("DeleteUser");
            Authentication.AuthenticateActivity("DeleteEmployee");

            user.IsMarkedAsDeleted = true;
            user.DateDeleted = DateTime.Now;

            EmployeeReader.GetEmployeeByUserId(user.Id, false)?.DeleteUserFromEmployee();

            user.Save();
        }

        public static void MarkUserAsDeleted(int userId)
        {
            Authentication.AuthenticateActivity("DeleteUser");
            Authentication.AuthenticateActivity("DeleteEmployee");

            var user = new UserEntity(userId)
            {
                IsMarkedAsDeleted = true,
                DateDeleted = DateTime.Now
            };

            EmployeeReader.GetEmployeeByUserId(user.Id, false)?.DeleteUserFromEmployee();

            user.Save();
        }
    }
}
