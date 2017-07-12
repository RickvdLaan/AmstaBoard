using System;
using System.Security.Cryptography;

namespace AmstaJanBonga.Business.Security
{
    public abstract class PasswordHash
    {
        #region Constants

        private const int HASH_BYTE_SIZE = 24;         // To match the size of the PBKDF2-HMAC-SHA-1 hash  (192-bit)

        #endregion

        #region Methods

        /// <summary>
        /// Hashes the provided password and returns the hash value.
        /// </summary>
        /// <param name="password">Provide the password in plain text.</param>
        /// <param name="salt">Provide a RNGCryptoServiceProvider generated salt.</param>
        /// <returns>The hash value.</returns>
        public static string HashPassword(string password, byte[] salt, int iterations)
        {
            var hash = GetPbkdf2Bytes(password, salt, iterations, HASH_BYTE_SIZE);

            return Convert.ToBase64String(hash);
        }

        /// <summary>
        /// Validates whether the provided password and string are equal to the stored hash.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <param name="storedHash"></param>
        /// <returns></returns>
        public static bool ValidatePassword(string password, string salt, string storedHash, int iterations)
        {
            var hash = GetPbkdf2Bytes(password, Convert.FromBase64String(salt), iterations, HASH_BYTE_SIZE);

            return SlowEquals(Convert.FromBase64String(storedHash), hash);
        }

        private static bool SlowEquals(byte[] a, byte[] b)
        {
            // Length constant verification - prevents timing attack
            var diff = (uint)a.Length ^ (uint)b.Length;

            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= (uint)(a[i] ^ b[i]);
            }

            return diff == 0;
        }

        private static byte[] GetPbkdf2Bytes(string password, byte[] salt, int iterations, int outputBytes)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt);

            pbkdf2.IterationCount = iterations;

            return pbkdf2.GetBytes(outputBytes);
        }
    }

    #endregion
}
