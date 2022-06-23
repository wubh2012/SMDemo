
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSMKeyHex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSM4Key = new System.Windows.Forms.TextBox();
            this.btnSM4Decode = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSM4Encrypt = new System.Windows.Forms.Button();
            this.btnSM3Hash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txtSMKeyHex);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtSM4Key);
            this.splitContainer1.Panel1.Controls.Add(this.btnSM4Decode);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSM4Encrypt);
            this.splitContainer1.Panel1.Controls.Add(this.btnSM3Hash);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtOrigin);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtEnc);
            this.splitContainer1.Size = new System.Drawing.Size(854, 450);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 5;
            this.label4.Text = "SM4密钥Hex";
            // 
            // txtSMKeyHex
            // 
            this.txtSMKeyHex.Location = new System.Drawing.Point(526, 183);
            this.txtSMKeyHex.Name = "txtSMKeyHex";
            this.txtSMKeyHex.ReadOnly = true;
            this.txtSMKeyHex.Size = new System.Drawing.Size(308, 22);
            this.txtSMKeyHex.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "SM4密钥：";
            // 
            // txtSM4Key
            // 
            this.txtSM4Key.Location = new System.Drawing.Point(526, 155);
            this.txtSM4Key.Name = "txtSM4Key";
            this.txtSM4Key.Size = new System.Drawing.Size(308, 22);
            this.txtSM4Key.TabIndex = 3;
            this.txtSM4Key.Text = "0123456789012345";
            // 
            // btnSM4Decode
            // 
            this.btnSM4Decode.Location = new System.Drawing.Point(310, 149);
            this.btnSM4Decode.Name = "btnSM4Decode";
            this.btnSM4Decode.Size = new System.Drawing.Size(101, 23);
            this.btnSM4Decode.TabIndex = 2;
            this.btnSM4Decode.Text = "SM4解密CBC";
            this.btnSM4Decode.UseVisualStyleBackColor = true;
            this.btnSM4Decode.Click += new System.EventHandler(this.btnSM4Decode_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "SM4解密ECB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "SM4加密ECB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSM4Encrypt
            // 
            this.btnSM4Encrypt.Location = new System.Drawing.Point(192, 149);
            this.btnSM4Encrypt.Name = "btnSM4Encrypt";
            this.btnSM4Encrypt.Size = new System.Drawing.Size(102, 23);
            this.btnSM4Encrypt.TabIndex = 2;
            this.btnSM4Encrypt.Text = "SM4加密CBC";
            this.btnSM4Encrypt.UseVisualStyleBackColor = true;
            this.btnSM4Encrypt.Click += new System.EventHandler(this.btnSM4Encrypt_Click);
            // 
            // btnSM3Hash
            // 
            this.btnSM3Hash.Location = new System.Drawing.Point(67, 170);
            this.btnSM3Hash.Name = "btnSM3Hash";
            this.btnSM3Hash.Size = new System.Drawing.Size(112, 23);
            this.btnSM3Hash.TabIndex = 2;
            this.btnSM3Hash.Text = "SM3计算Hash";
            this.btnSM3Hash.UseVisualStyleBackColor = true;
            this.btnSM3Hash.Click += new System.EventHandler(this.btnSM3Hash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "原文：";
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(67, 16);
            this.txtOrigin.Multiline = true;
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(767, 112);
            this.txtOrigin.TabIndex = 0;
            this.txtOrigin.Text = "123456";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "密文：";
            // 
            // txtEnc
            // 
            this.txtEnc.Location = new System.Drawing.Point(67, 3);
            this.txtEnc.Multiline = true;
            this.txtEnc.Name = "txtEnc";
            this.txtEnc.Size = new System.Drawing.Size(767, 214);
            this.txtEnc.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "SM4/ECB/PKCS7Padding";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "SM4/CBC/PKCS7Padding";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEnc;
        private System.Windows.Forms.Button btnSM3Hash;
        private System.Windows.Forms.Button btnSM4Decode;
        private System.Windows.Forms.Button btnSM4Encrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSM4Key;
        private System.Windows.Forms.TextBox txtSMKeyHex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

