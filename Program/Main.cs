using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace TripleDESTest
{
    public partial class Main : Form
    {
        byte[] key;
        byte[] iv;
        TripleDES tripledes;

        public Main()
        {
            InitializeComponent();

            key = Encoding.UTF8.GetBytes("TestKey1234567890!!!!!!!");
            iv = Encoding.UTF8.GetBytes("iv123!!!");

            textbox.Text = "Hello 3DES! 中文测试";

            tripledes = TripleDES.Create();

            // important!!!
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.Zeros;
        }

        private void EncryptData_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.UTF8.GetBytes(textbox.Text);
            ICryptoTransform transform = tripledes.CreateEncryptor(key, iv);
            byte[] encrypted = transform.TransformFinalBlock(data, 0, data.Length);
            textbox.Text = Convert.ToBase64String(encrypted);

            transform.Dispose();
            tripledes.Clear();
        }

        private void DecryptData_Click(object sender, EventArgs e)
        {
            char[] encrypted = textbox.Text.ToCharArray();
            byte[] data = Convert.FromBase64CharArray(encrypted, 0, encrypted.Length);
            ICryptoTransform transform = tripledes.CreateDecryptor(key, iv);
            byte[] decrypted = transform.TransformFinalBlock(data, 0, data.Length);
            textbox.Text = Encoding.UTF8.GetString(decrypted);

            transform.Dispose();
            tripledes.Clear();
        }
    }
}
