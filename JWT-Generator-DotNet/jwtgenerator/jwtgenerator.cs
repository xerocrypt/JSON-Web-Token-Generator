using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace JWT_Generator
{

    class jwt_generator
    {

        public string GenerateToken(string header, string payload, string secretKey)
        {
            string encodedHeaderString = ConvertHeaderToJson(header);
            string encodedPayloadString = ConvertPayloadToJson(payload);
            string encodedSignature = GetEncodedSignature(secretKey, encodedHeaderString, encodedPayloadString);

            string generatedToken = encodedHeaderString + "." + encodedPayloadString + "." + encodedSignature;

            return generatedToken;
        }


        private static string ConvertHeaderToJson(string headerString)
        {
            byte[] headerStringAsBytes = Encoding.ASCII.GetBytes(headerString);
            string encodedHeaderString = Convert.ToBase64String(headerStringAsBytes);
            return encodedHeaderString;
        }



        private static string ConvertPayloadToJson(string payloadString)
        {
            // Convert the token payload to the actual token
            byte[] payloadStringAsBytes = Encoding.ASCII.GetBytes(payloadString);
            string encodedPayloadString = Convert.ToBase64String(payloadStringAsBytes);
            return encodedPayloadString;
        }

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
