using OtpNet;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Drawing;
using System.IO;

namespace DataAccessLibrary.Helpers
{
    public class TwoFAHelper
    {
        public static string GenerateSecretKey()
        {
            var key = KeyGeneration.GenerateRandomKey(20);
            return Base32Encoding.ToString(key);
        }

        public static string GetOtpAuthUrl(string issuer, string user, string secretKey)
        {
            return $"otpauth://totp/{issuer}:{user}?secret={secretKey}&issuer={issuer}";
        }

        public static bool VerifyCode(string secretKey, string userInputCode)
        {
            var totp = new Totp(Base32Encoding.ToBytes(secretKey));
            return totp.VerifyTotp(userInputCode, out _, VerificationWindow.RfcSpecifiedNetworkDelay);
        }
    }
}
