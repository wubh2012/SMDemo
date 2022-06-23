
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

        private void btnSM3Hash_Click(object sender, EventArgs e)
        {
            txtEnc.Text = Sm3Utils.GetHash(txtOrigin.Text);
        }


        private void btnSM4Encrypt_Click(object sender, EventArgs e)
        {
            var key = txtSM4Key.Text;
            txtEnc.Text = Sm4Utils.EncryptCBC(txtOrigin.Text, key);

            var keyBytes = Encoding.UTF8.GetBytes(key);
            txtSMKeyHex.Text = Hex.ToHexString(keyBytes);
        }

        private void btnSM4Decode_Click(object sender, EventArgs e)
        {
            txtOrigin.Text = Sm4Utils.DecryptCBC(txtEnc.Text, txtSM4Key.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEnc.Text = Sm4Utils.EncryptEBC(txtOrigin.Text, txtSM4Key.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOrigin.Text = Sm4Utils.DecryptEBC(txtEnc.Text, txtSM4Key.Text);
        }
    }
}
