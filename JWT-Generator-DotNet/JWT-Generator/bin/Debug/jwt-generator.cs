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
        public string GenerateTokenHeader(string headerData)
        {
            TokenHeader tokenHeader = new TokenHeader();
            tokenHeader.alg = "HS256";
            tokenHeader.typ = "JWT";

            string headerString = JsonConvert.SerializeObject(tokenHeader);

            string encodedHeaderString = ConvertHeaderToJson(headerString);

            return encodedHeaderString;
        }


        private static string ConvertHeaderToJson(string headerString)
        {
            byte[] headerStringAsBytes = Encoding.ASCII.GetBytes(headerString);
            string encodedHeaderString = Convert.ToBase64String(headerStringAsBytes);
            return encodedHeaderString;
        }

        public string GenerateTokenPayload(string subject, string name, string admin)
        {
            TokenPayload tokenPayload = new TokenPayload();
            tokenPayload.sub = subject;
            tokenPayload.name = name;
            tokenPayload.admin = admin;



            string payloadString = JsonConvert.SerializeObject(tokenPayload);
            string encodedPayloadString = ConvertPayloadToJson(payloadString);

            return encodedPayloadString;
        }


        private static string ConvertPayloadToJson(string payloadString)
        {
            // Convert the token payload to the actual token
            byte[] payloadStringAsBytes = Encoding.ASCII.GetBytes(payloadString);
            string encodedPayloadString = Convert.ToBase64String(payloadStringAsBytes);
            return encodedPayloadString;
        }

        public string SignToken(string headerData, string subject, string name, string admin, string secretKey)
        {
            string encodedHeaderString = GenerateTokenHeader(headerData);
            string encodedPayloadString = GenerateTokenPayload(subject, name, admin);

            string message = encodedHeaderString + "." + encodedPayloadString;
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(secretKey);

            HMACSHA256 hmacsha256 = new HMACSHA256(keyByte);

            byte[] messageBytes = encoding.GetBytes(message);
            byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
            string hashAsString = BitConverter.ToString(hashmessage);

            // Convert the hash signature to Base64 string
            byte[] signatureStringAsBytes = Encoding.ASCII.GetBytes(hashAsString);
            string encodedSignature = Convert.ToBase64String(signatureStringAsBytes);
            return encodedSignature;
        }



        public string GenerateToken(string headerData, string subject, string name, string admin, string secretKey)
        {
            string encodedHeaderString = GenerateTokenHeader(headerData);
            string encodedPayloadString = GenerateTokenPayload(subject, name, admin);
            string encodedSignature = SignToken(headerData, subject, name, admin, secretKey);

            string fullToken = encodedHeaderString + "." + encodedPayloadString + "." + encodedSignature;

            return fullToken;
        }
    }
}
