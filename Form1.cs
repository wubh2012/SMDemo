
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSM4_CBC_Encrypt_Click(object sender, EventArgs e)
        {
            var key = txtSM4Key.Text;
            txtSM4Output.Text = Sm4Utils.EncryptCBC(txtSM4Input.Text, key);

            var keyBytes = Encoding.UTF8.GetBytes(key);
            txtSMKeyHex.Text = Hex.ToHexString(keyBytes);
        }

        private void btnSM4_CBC_Decrypt_Click(object sender, EventArgs e)
        {
            txtSM4Input.Text = Sm4Utils.DecryptCBC(txtSM4Output.Text, txtSM4Key.Text);
        }

        private void btnSM4_EBC_Encrypt(object sender, EventArgs e)
        {
            txtSM4Output.Text = Sm4Utils.EncryptEBC(txtSM4Input.Text, txtSM4Key.Text);
        }

        private void btnSM4_EBC_Decrypt(object sender, EventArgs e)
        {
            txtSM4Input.Text = Sm4Utils.DecryptEBC(txtSM4Output.Text, txtSM4Key.Text);
        }

        private void btnSM3Hash_Click_1(object sender, EventArgs e)
        {
            txtSM3Output.Text = Sm3Utils.GetHash(txtSM3Input.Text);
        }

        private void btnSM2CreateKey_Click(object sender, EventArgs e)
        {
            SM2Utils sM2Utils = new SM2Utils();
            var keyPair = sM2Utils.GenerateKey();
            txtSM2_PublicKey.Text = keyPair.PublicKey;
            txtSM2_PrivateKey.Text = keyPair.PrivateKey;

        }

        private void btnSM2Encrypt_Click(object sender, EventArgs e)
        {
            SM2Utils sM2Utils = new SM2Utils();
            txtSM2Output.Text = sM2Utils.Encrypt(txtSM2_PublicKey.Text, txtSM2Input.Text);
        }

        private void btnSM2Decrypt_Click(object sender, EventArgs e)
        {
            SM2Utils sM2Utils = new SM2Utils();
            txtSM2Input.Text = sM2Utils.Decrypt(txtSM2_PrivateKey.Text, txtSM2Output.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            byte[] ba = Encoding.UTF8.GetBytes(txtSM2Input.Text);
            var hexString = BitConverter.ToString(ba);
            hexString = hexString.Replace("-", "");

            txtSM2Output.Text = hexString;

            txtSM2Output.Text += "\r\n" + Hex.ToHexString(ba);

            txtSM2Output.Text += "\r\n" + Convert.ToBase64String(ba);



        }
    }
}
