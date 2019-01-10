using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace JWT_Generator
{
    class GenerateTokenSignature
    {
        private static string GetEncodedSignature(string myKey, string encodedHeaderString, string encodedPayloadString)
        {
            string message = encodedHeaderString + "." + encodedPayloadString;
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(myKey);

            HMACSHA256 hmacsha256 = new HMACSHA256(keyByte);

            byte[] messageBytes = encoding.GetBytes(message);
            byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
            string hashAsString = BitConverter.ToString(hashmessage);

            // Convert the hash signature to Base64 string
            byte[] signatureStringAsBytes = Encoding.ASCII.GetBytes(hashAsString);
            string encodedSignature = Convert.ToBase64String(signatureStringAsBytes);
            return encodedSignature;
        }
    }
}
