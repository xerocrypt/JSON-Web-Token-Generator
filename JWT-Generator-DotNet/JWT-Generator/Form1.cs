using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Json.Net;
using Newtonsoft.Json;
using System.Security.Cryptography;

namespace JWT_Generator
{
    public partial class frmTokenGenerator : Form
    {
        public frmTokenGenerator()
        {
            InitializeComponent();
        }


        public class TokenHeader
        {
            public string alg { get; set; }
            public string typ { get; set; }
        }

        public class TokenPayload
        {
            public string sub { get; set; }
            public string name { get; set; }
            public string admin { get; set; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //These are static token header values
            TokenHeader tokenHeader = new TokenHeader();
            tokenHeader.alg = "HS256";
            tokenHeader.typ = "JWT";



            TokenPayload tokenPayload = new TokenPayload();
            tokenPayload.sub = txtTokenSubject.Text;
            tokenPayload.name = txtName.Text;
            tokenPayload.admin = cmbIsAdmin.Text;

            string myKey = txtKey.Text;


            string headerString = JsonConvert.SerializeObject(tokenHeader);
            string payloadString = JsonConvert.SerializeObject(tokenPayload);


            // Convert the token header to the actual token
            string encodedHeaderString = ConvertHeaderToJson(headerString);
            string encodedPayloadString = ConvertPayloadToJson(payloadString);
            string encodedSignature = GetEncodedSignature(myKey, encodedHeaderString, encodedPayloadString);


            DisplayGeneratedToken(headerString, payloadString, encodedHeaderString, encodedPayloadString, encodedSignature);

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


        private void DisplayGeneratedToken(string headerString, string payloadString, string encodedHeaderString, string encodedPayloadString, string encodedSignature)
        {
            txtJsonData.Text = headerString + payloadString;
            txtEncodedToken.Text = encodedHeaderString + "." + encodedPayloadString + "." + encodedSignature;
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


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
