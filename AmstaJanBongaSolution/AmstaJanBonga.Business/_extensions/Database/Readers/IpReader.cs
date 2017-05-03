using AmstaJanBonga.Business.CollectionClasses;
using AmstaJanBonga.Business.EntityClasses;

namespace AmstaJanBonga.Business.Database.Readers
{
    public abstract class IpReader
    {
        /// <summary>
        /// Validates whether the IP is added tp the database, thus if it's allowed.
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <returns></returns>
        public static bool IsIpAllowed(string ipAddress)
        {
            var ip = new IpEntity(ipAddress);

            return (ip.IsNew == false);
        }

        /// <summary>
        /// Returns a collection of all IP addresses.
        /// </summary>
        /// <returns></returns>
        public static IpCollection GetAllIps()
        {
            var ips = new IpCollection();
            ips.GetMulti(null, -1);

            return ips;
        }
    }
}
