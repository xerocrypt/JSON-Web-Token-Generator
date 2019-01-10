using System;
using System.Text;
using System.Windows.Forms;
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


        private void button1_Click(object sender, EventArgs e)
        {
            string myKey = txtKey.Text;

            string tokenHeader = txtInputHeader.Text;
            string tokenPayload = txtInputPayload.Text;

            // Convert the token header to the actual token
            string encodedHeaderString = ConvertHeaderToJson(tokenHeader);
            string encodedPayloadString = ConvertPayloadToJson(tokenPayload);
            string encodedSignature = GetEncodedSignature(myKey, encodedHeaderString, encodedPayloadString);


            DisplayGeneratedToken(tokenHeader, tokenPayload, encodedHeaderString, encodedPayloadString, encodedSignature);
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

        private void frmTokenGenerator_Load(object sender, EventArgs e)
        {

        }
    }
}
