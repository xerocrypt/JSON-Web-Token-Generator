# JSON-Web-Token-Generator
A .NET application and resources for JSON Web Token authentication.


## Dependencies

<code>
using Newtonsoft.Json;
            
using System.Security.Cryptography;

</code>

## Token Header
            TokenHeader tokenHeader = new TokenHeader();
            tokenHeader.alg = "HS256";
            tokenHeader.typ = "JWT";

Converting header to JSON:

string headerString = JsonConvert.SerializeObject(tokenHeader);

            byte[] headerStringAsBytes = Encoding.ASCII.GetBytes(headerString);
            string encodedHeaderString = Convert.ToBase64String(headerStringAsBytes);
            return encodedHeaderString;


## Token Payload
            TokenPayload tokenPayload = new TokenPayload();
            tokenPayload.sub = txtTokenSubject.Text;
            tokenPayload.name = txtName.Text;
            tokenPayload.admin = cmbIsAdmin.Text;

Converting payload to Base64:
string payloadString = JsonConvert.SerializeObject(tokenPayload);

            // Convert the token payload to the actual token
            byte[] payloadStringAsBytes = Encoding.ASCII.GetBytes(payloadString);
            string encodedPayloadString = Convert.ToBase64String(payloadStringAsBytes);
            return encodedPayloadString;


## Converting to JSON
            string headerString = JsonConvert.SerializeObject(tokenHeader);
            string payloadString = JsonConvert.SerializeObject(tokenPayload);


## Token Signature


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
