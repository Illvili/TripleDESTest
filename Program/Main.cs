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
        TripleDES tripledes;

        public Main()
        {
            InitializeComponent();

            plaintext.Text = "Hello 3DES! 中文测试";

            tripledes = TripleDES.Create();

            // important!!!
            tripledes.Mode = CipherMode.CBC;
            tripledes.Padding = PaddingMode.Zeros;
        }

        private void EncryptData_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = Encoding.UTF8.GetBytes(plaintext.Text);
                using (ICryptoTransform transform = tripledes.CreateEncryptor(Encoding.UTF8.GetBytes(TDESKey.Text), Encoding.UTF8.GetBytes(TDESIV.Text)))
                {
                    byte[] encrypted = transform.TransformFinalBlock(data, 0, data.Length);
                    ciphertext.Text = Convert.ToBase64String(encrypted);
                }
            }
            catch (Exception ex)
            {
                ciphertext.Text = ex.Message;
            }
            finally
            {
                tripledes.Clear();
            }
        }

        private void DecryptData_Click(object sender, EventArgs e)
        {
            try
            {
                char[] encrypted = ciphertext.Text.ToCharArray();
                byte[] data = Convert.FromBase64CharArray(encrypted, 0, encrypted.Length);
                using (ICryptoTransform transform = tripledes.CreateDecryptor(Encoding.UTF8.GetBytes(TDESKey.Text), Encoding.UTF8.GetBytes(TDESIV.Text)))
                {
                    byte[] decrypted = transform.TransformFinalBlock(data, 0, data.Length);
                    plaintext.Text = Encoding.UTF8.GetString(decrypted);
                }
            }
            catch (Exception ex)
            {
                plaintext.Text = ex.Message;
            }
            finally
            {
                tripledes.Clear();
            }
        }
    }
}
