# JSON Web Token Generator


### Dependencies
* jquery-3.3.1.min.js
* jquery.base64.min.js 
* crypto-js.min.js
* hmac-sha256.min.js
* enc-base64.min.js


### TokenHeader(headerData)
Encodes a token header.


### TokenPayload(payloadData)
Encodes a token payload.


### SignToken(headerData, payloadData, secretKey)
Returns a HMAC SHA256 signature for associated header and payload.


### GenerateToken(headerData, payloadData, secretKey)
This function returns a full JSON Web Token after using the HMAC SHA256 algorithm to generate a signature for an accepted token header and payload.
