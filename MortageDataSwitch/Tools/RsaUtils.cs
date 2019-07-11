using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
using System.Web.Configuration;

namespace MortageDataSwitch.Tools
{
    /// <summary>
    /// Utils to help encrypt data
    /// </summary>
    public static class RsaUtils
    {
        private static readonly log4net.ILog LOG = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Certificate overwride
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="certificate"></param>
        /// <param name="chain"></param>
        /// <param name="policyErrors"></param>
        /// <returns></returns>
        public static bool ValidateRemoteCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors policyErrors)
        {
            return true;
        }

        public static string Encrypt(string publicKey, string plainText)
        {
            byte[] plainTextBytes;
            byte[] cipherTextBytes;

            RSACryptoServiceProvider rsaEncrypt = new RSACryptoServiceProvider();
            rsaEncrypt.FromXmlString(publicKey);

            if (plainText.Length > 58)
            {
                throw new CryptographicException("Plaintext string to encrypt to long");
            }

            plainTextBytes = Encoding.ASCII.GetBytes(plainText);
            cipherTextBytes = rsaEncrypt.Encrypt(plainTextBytes, false);

            return Convert.ToBase64String(cipherTextBytes);
        }

        public static string Hash(string xmlString)
        {
            byte[] textBytes;

            StringBuilder builderResult = new StringBuilder(40);
            SHA1Managed shaCalculator = new SHA1Managed();
            textBytes = Encoding.ASCII.GetBytes(xmlString);
            byte[] SHA1Result = shaCalculator.ComputeHash(textBytes);

            for (int i = 0; i <= SHA1Result.Length - 1; i++)
            {
                builderResult.Append(String.Format("{0:x2}", SHA1Result[i]).ToUpper());
            }
            return builderResult.ToString();
        }
    }
}