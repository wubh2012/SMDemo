
namespace SMDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSM2CreateKey = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSM2_PrivateKey = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSM2_PublicKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSM2Output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSM2Input = new System.Windows.Forms.TextBox();
            this.btnSM2Decrypt = new System.Windows.Forms.Button();
            this.btnSM2Encrypt = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSM3Output = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSM3Input = new System.Windows.Forms.TextBox();
            this.btnSM3Hash = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSM4Decode = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSM4Encrypt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSMKeyHex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSM4Key = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSM4Output = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSM4Input = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(993, 505);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btnSM2CreateKey);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtSM2_PrivateKey);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtSM2_PublicKey);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtSM2Output);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtSM2Input);
            this.tabPage1.Controls.Add(this.btnSM2Decrypt);
            this.tabPage1.Controls.Add(this.btnSM2Encrypt);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(985, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SM2";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSM2CreateKey
            // 
            this.btnSM2CreateKey.Location = new System.Drawing.Point(65, 146);
            this.btnSM2CreateKey.Name = "btnSM2CreateKey";
            this.btnSM2CreateKey.Size = new System.Drawing.Size(129, 23);
            this.btnSM2CreateKey.TabIndex = 1;
            this.btnSM2CreateKey.Text = "生成密钥对";
            this.btnSM2CreateKey.UseVisualStyleBackColor = true;
            this.btnSM2CreateKey.Click += new System.EventHandler(this.btnSM2CreateKey_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(483, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 14);
            this.label12.TabIndex = 16;
            this.label12.Text = "私钥：";
            // 
            // txtSM2_PrivateKey
            // 
            this.txtSM2_PrivateKey.Location = new System.Drawing.Point(538, 207);
            this.txtSM2_PrivateKey.Multiline = true;
            this.txtSM2_PrivateKey.Name = "txtSM2_PrivateKey";
            this.txtSM2_PrivateKey.Size = new System.Drawing.Size(354, 155);
            this.txtSM2_PrivateKey.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(483, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 14);
            this.label11.TabIndex = 14;
            this.label11.Text = "公钥：";
            // 
            // txtSM2_PublicKey
            // 
            this.txtSM2_PublicKey.Location = new System.Drawing.Point(538, 6);
            this.txtSM2_PublicKey.Multiline = true;
            this.txtSM2_PublicKey.Name = "txtSM2_PublicKey";
            this.txtSM2_PublicKey.Size = new System.Drawing.Size(354, 112);
            this.txtSM2_PublicKey.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "结果：";
            // 
            // txtSM2Output
            // 
            this.txtSM2Output.Location = new System.Drawing.Point(54, 207);
            this.txtSM2Output.Multiline = true;
            this.txtSM2Output.Name = "txtSM2Output";
            this.txtSM2Output.Size = new System.Drawing.Size(411, 155);
            this.txtSM2Output.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "原文：";
            // 
            // txtSM2Input
            // 
            this.txtSM2Input.Location = new System.Drawing.Point(65, 6);
            this.txtSM2Input.Multiline = true;
            this.txtSM2Input.Name = "txtSM2Input";
            this.txtSM2Input.Size = new System.Drawing.Size(400, 112);
            this.txtSM2Input.TabIndex = 0;
            this.txtSM2Input.Text = "123456";
            // 
            // btnSM2Decrypt
            // 
            this.btnSM2Decrypt.Location = new System.Drawing.Point(353, 146);
            this.btnSM2Decrypt.Name = "btnSM2Decrypt";
            this.btnSM2Decrypt.Size = new System.Drawing.Size(112, 23);
            this.btnSM2Decrypt.TabIndex = 3;
            this.btnSM2Decrypt.Text = "SM2解密";
            this.btnSM2Decrypt.UseVisualStyleBackColor = true;
            this.btnSM2Decrypt.Click += new System.EventHandler(this.btnSM2Decrypt_Click);
            // 
            // btnSM2Encrypt
            // 
            this.btnSM2Encrypt.Location = new System.Drawing.Point(218, 146);
            this.btnSM2Encrypt.Name = "btnSM2Encrypt";
            this.btnSM2Encrypt.Size = new System.Drawing.Size(112, 23);
            this.btnSM2Encrypt.TabIndex = 2;
            this.btnSM2Encrypt.Text = "SM2加密";
            this.btnSM2Encrypt.UseVisualStyleBackColor = true;
            this.btnSM2Encrypt.Click += new System.EventHandler(this.btnSM2Encrypt_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtSM3Output);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtSM3Input);
            this.tabPage2.Controls.Add(this.btnSM3Hash);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(985, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SM3";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 14);
            this.label10.TabIndex = 8;
            this.label10.Text = "结果：";
            // 
            // txtSM3Output
            // 
            this.txtSM3Output.Location = new System.Drawing.Point(61, 179);
            this.txtSM3Output.Multiline = true;
            this.txtSM3Output.Name = "txtSM3Output";
            this.txtSM3Output.Size = new System.Drawing.Size(681, 177);
            this.txtSM3Output.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "原文：";
            // 
            // txtSM3Input
            // 
            this.txtSM3Input.Location = new System.Drawing.Point(61, 18);
            this.txtSM3Input.Multiline = true;
            this.txtSM3Input.Name = "txtSM3Input";
            this.txtSM3Input.Size = new System.Drawing.Size(681, 87);
            this.txtSM3Input.TabIndex = 0;
            this.txtSM3Input.Text = "123456";
            // 
            // btnSM3Hash
            // 
            this.btnSM3Hash.Location = new System.Drawing.Point(61, 134);
            this.btnSM3Hash.Name = "btnSM3Hash";
            this.btnSM3Hash.Size = new System.Drawing.Size(112, 23);
            this.btnSM3Hash.TabIndex = 1;
            this.btnSM3Hash.Text = "SM3计算Hash";
            this.btnSM3Hash.UseVisualStyleBackColor = true;
            this.btnSM3Hash.Click += new System.EventHandler(this.btnSM3Hash_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btnSM4Decode);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.btnSM4Encrypt);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtSMKeyHex);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.txtSM4Key);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtSM4Output);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtSM4Input);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(985, 478);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SM4";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "SM4/CBC/PKCS7Padding";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "SM4/ECB/PKCS7Padding";
            // 
            // btnSM4Decode
            // 
            this.btnSM4Decode.Location = new System.Drawing.Point(195, 139);
            this.btnSM4Decode.Name = "btnSM4Decode";
            this.btnSM4Decode.Size = new System.Drawing.Size(101, 23);
            this.btnSM4Decode.TabIndex = 3;
            this.btnSM4Decode.Text = "SM4解密CBC";
            this.btnSM4Decode.UseVisualStyleBackColor = true;
            this.btnSM4Decode.Click += new System.EventHandler(this.btnSM4_CBC_Decrypt_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "SM4解密ECB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSM4_EBC_Decrypt);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "SM4加密ECB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSM4_EBC_Encrypt);
            // 
            // btnSM4Encrypt
            // 
            this.btnSM4Encrypt.Location = new System.Drawing.Point(64, 139);
            this.btnSM4Encrypt.Name = "btnSM4Encrypt";
            this.btnSM4Encrypt.Size = new System.Drawing.Size(102, 23);
            this.btnSM4Encrypt.TabIndex = 2;
            this.btnSM4Encrypt.Text = "SM4加密CBC";
            this.btnSM4Encrypt.UseVisualStyleBackColor = true;
            this.btnSM4Encrypt.Click += new System.EventHandler(this.btnSM4_CBC_Encrypt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "SM4密钥Hex";
            // 
            // txtSMKeyHex
            // 
            this.txtSMKeyHex.Location = new System.Drawing.Point(373, 102);
            this.txtSMKeyHex.Name = "txtSMKeyHex";
            this.txtSMKeyHex.ReadOnly = true;
            this.txtSMKeyHex.Size = new System.Drawing.Size(250, 22);
            this.txtSMKeyHex.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "SM4密钥：";
            // 
            // txtSM4Key
            // 
            this.txtSM4Key.Location = new System.Drawing.Point(64, 102);
            this.txtSM4Key.Name = "txtSM4Key";
            this.txtSM4Key.Size = new System.Drawing.Size(160, 22);
            this.txtSM4Key.TabIndex = 1;
            this.txtSM4Key.Text = "0123456789012345";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "密文（HEX格式）：";
            // 
            // txtSM4Output
            // 
            this.txtSM4Output.Location = new System.Drawing.Point(54, 230);
            this.txtSM4Output.Multiline = true;
            this.txtSM4Output.Name = "txtSM4Output";
            this.txtSM4Output.Size = new System.Drawing.Size(620, 199);
            this.txtSM4Output.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "原文：";
            // 
            // txtSM4Input
            // 
            this.txtSM4Input.Location = new System.Drawing.Point(64, 6);
            this.txtSM4Input.Multiline = true;
            this.txtSM4Input.Name = "txtSM4Input";
            this.txtSM4Input.Size = new System.Drawing.Size(610, 83);
            this.txtSM4Input.TabIndex = 0;
            this.txtSM4Input.Text = "123456";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(54, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 505);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnSM3Hash;
        private System.Windows.Forms.TextBox txtSM3Output;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSM3Input;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSM4Output;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSM4Input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSM4Decode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSM4Encrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSMKeyHex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSM4Key;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSM2Output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSM2Input;
        private System.Windows.Forms.Button btnSM2Encrypt;
        private System.Windows.Forms.Button btnSM2Decrypt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSM2_PublicKey;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSM2_PrivateKey;
        private System.Windows.Forms.Button btnSM2CreateKey;
        private System.Windows.Forms.Button button3;
    }
}

