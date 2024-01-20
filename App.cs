using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Net.Sockets;
using static System.Net.Mime.MediaTypeNames;

namespace encryption_app
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        static string Encrypt(string plainText, string secretKeyBase64, string ivBase64)
        {
            byte[] secretKey = Convert.FromBase64String(secretKeyBase64);
            byte[] iv = Convert.FromBase64String(ivBase64);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = secretKey;
                aesAlg.IV = iv;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }


        static string Decrypt(string cipherText, string secretKeyBase64, string ivBase64)
        {
            byte[] secretKey = Convert.FromBase64String(secretKeyBase64);
            byte[] iv = Convert.FromBase64String(ivBase64);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = secretKey;
                aesAlg.IV = iv;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }


        static byte[] Generate_Secret()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] key = new byte[32]; // 256 bits
                rng.GetBytes(key);
                return key;
            }
        }


        static byte[] Generate_IV()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] iv = new byte[16]; // 128 bits
                rng.GetBytes(iv);
                return iv;
            }
        }


        (string, string, string) Get_User_Input()
        {
            string user_txt = txtLeft.Text;
            string secret = txtSecretkey.Text;
            string iv = txtIVkey.Text;

            var output = (user_txt, secret, iv);

            return output;
        }


        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                (string user_txt, string secret, string iv) = Get_User_Input();
                string ec_txt = Encrypt(user_txt, secret, iv);

                txtRight.Text = ec_txt;
            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR | {error.Message}\nCODE | {error.HResult}");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                (string user_txt, string secret, string iv) = Get_User_Input();
                string dc_txt = Decrypt(user_txt, secret, iv);

                txtRight.Text = dc_txt;
            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR:    {error.Message}\nCODE:      {error.HResult}");
            }
        }

        private void btnGenSecret_Click(object sender, EventArgs e)
        {
            string secret64 = Convert.ToBase64String(Generate_Secret());
            txtSecretkey.Text = secret64;
        }

        private void btnGenIV_Click(object sender, EventArgs e)
        {
            string iv64 = Convert.ToBase64String(Generate_IV());
            txtIVkey.Text = iv64;

        }

    }
}
