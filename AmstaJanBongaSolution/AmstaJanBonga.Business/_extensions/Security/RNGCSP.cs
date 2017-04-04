using System;
using System.Security.Cryptography;

namespace AmstaJanBonga.Business.Security
{
    public class RNGCSP
    {
        #region Constants

        internal const int SALT_BYTE_SIZE = 24;

        #endregion

        #region Methods

        /// <summary>
        /// Generates a random salt with the crypto service provider.
        /// </summary>
        /// <returns></returns>
        public static byte[] GenerateRandomSalt()
        {
            var salt = new byte[SALT_BYTE_SIZE];

            using (var rngcsp = new RNGCryptoServiceProvider())
            {
                rngcsp.GetBytes(salt);
            }

            return salt;
        }

        #endregion
    }
}
