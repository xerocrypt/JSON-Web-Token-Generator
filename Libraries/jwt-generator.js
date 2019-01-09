function TokenHeader(headerData)
{
    var headerjson = ' + headerData + ',
    headerobj = JSON.parse(headerjson);

    encodedHeader = btoa(unescape(encodeURIComponent(headerjson)));
    encodedHeaderString = decodeURIComponent(escape(window.atob(encodedHeader)));
    return encodedHeaderString;
}

function TokenPayload(payloadData)
{
    var payloadjson = ' + payloadAData + ',
    payloadobj = JSON.parse(payloadjson);

    encodedPayload = btoa(unescape(encodeURIComponent(payloadjson)));
    encodedPayloadString = decodeURIComponent(escape(window.atob(encodedPayload)));
    return encodedPayloadString;
}

function SignToken(headerData, payloadData, secretKey)
{
    var headerjson = ' + headerData + ',
    headerobj = JSON.parse(headerjson);
    encodedHeader = btoa(unescape(encodeURIComponent(headerjson)));

    var payloadjson = ' + payloadAData + ',
    payloadobj = JSON.parse(payloadjson);
    encodedPayload = btoa(unescape(encodeURIComponent(payloadjson)));

    var unsignedToken = encodedHeader + "." + encodedPayload;

    // Use HMAC SHA256 to sign the unsigned token using the secret key
    var tokenSignature = CryptoJS.HmacSHA256(unsignedToken, secretKey);
    var encodedTokenSignature = CryptoJS.enc.Base64.stringify(tokenSignature);
        
    return encodedTokenSignature;
}

function GenerateToken(headerData, payloadData, secretKey)
{
    var tokenHeader = TokenHeader(headerData);
    var tokenPayload = TokenPayload(payloadData);
    var tokenSignature = SignToken(tokenHeader, tokenPayload, secretKey);


    fullToken = tokenHeader + "." + tokenPayload + "." + tokenSignature;
    return fullToken;
}
