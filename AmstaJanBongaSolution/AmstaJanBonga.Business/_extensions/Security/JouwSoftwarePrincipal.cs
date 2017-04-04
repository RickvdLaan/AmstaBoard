using AmstaJanBonga.Business.EntityClasses;
using AmstaJanBonga.Business.Enums;
using Rlaan.Toolkit.Extensions;
using System;
using System.Security.Principal;

namespace AmstaJanBonga.Business.Security
{
    /// <summary>
    /// Defines a principal class, this class cannot be inherited.
    /// </summary>
    [Serializable]
    public sealed class RlaanPrincipal : IPrincipal
    {
        #region IPrincipal

        private readonly IIdentity USER;

        public IIdentity Identity { get { return this.USER; } }
        public IIdentity User { get { return this.USER; } }

        public RlaanPrincipal(IIdentity user)
        {
            this.USER = user;
        }

        public bool IsInRole(string roleType)
        {
            try
            {
                return UserReader.IsUserInRole((UserEntity)this.USER, (RoleTypeEnum)Enum.Parse(typeof(RoleTypeEnum), roleType));
            }
            catch
            {
                throw new UnknownRoleTypeException(
                    "Unknown role type detected: {0}".FormatString(roleType));
            }
        }

        #endregion
    }
}
