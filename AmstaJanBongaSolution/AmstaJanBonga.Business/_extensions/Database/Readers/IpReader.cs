using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.Security;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class IpReader
    {
        /// <summary>
        /// Returns a collection of all IP addresses.
        /// </summary>
        /// <returns></returns>
        public static IpCollection GetAllIps()
        {
            // Login page on AmstaBord uses it before a user is authenticated.
            if (Authentication.IsAuthenticated)
                Authentication.AuthenticateActivity("ReadIP");

            var ips = new IpCollection();
            ips.GetMulti(null, -1);

            return ips;
        }
    }
}
