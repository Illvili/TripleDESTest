namespace TripleDESTest
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.plaintext = new System.Windows.Forms.TextBox();
            this.EncryptData = new System.Windows.Forms.Button();
            this.DecryptData = new System.Windows.Forms.Button();
            this.TDESKey = new System.Windows.Forms.TextBox();
            this.TDESIV = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ciphertext = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plaintext
            // 
            this.plaintext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plaintext.Location = new System.Drawing.Point(0, 0);
            this.plaintext.Multiline = true;
            this.plaintext.Name = "plaintext";
            this.plaintext.Size = new System.Drawing.Size(237, 218);
            this.plaintext.TabIndex = 0;
            // 
            // EncryptData
            // 
            this.EncryptData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EncryptData.Location = new System.Drawing.Point(12, 290);
            this.EncryptData.Name = "EncryptData";
            this.EncryptData.Size = new System.Drawing.Size(75, 23);
            this.EncryptData.TabIndex = 1;
            this.EncryptData.Text = "Encrypt";
            this.EncryptData.UseVisualStyleBackColor = true;
            this.EncryptData.Click += new System.EventHandler(this.EncryptData_Click);
            // 
            // DecryptData
            // 
            this.DecryptData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DecryptData.Location = new System.Drawing.Point(93, 290);
            this.DecryptData.Name = "DecryptData";
            this.DecryptData.Size = new System.Drawing.Size(75, 23);
            this.DecryptData.TabIndex = 2;
            this.DecryptData.Text = "Decrypt";
            this.DecryptData.UseVisualStyleBackColor = true;
            this.DecryptData.Click += new System.EventHandler(this.DecryptData_Click);
            // 
            // TDESKey
            // 
            this.TDESKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TDESKey.Location = new System.Drawing.Point(12, 12);
            this.TDESKey.MaxLength = 24;
            this.TDESKey.Name = "TDESKey";
            this.TDESKey.Size = new System.Drawing.Size(494, 21);
            this.TDESKey.TabIndex = 3;
            this.TDESKey.Text = "TestKey1234567890!!!!!!!";
            // 
            // TDESIV
            // 
            this.TDESIV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TDESIV.Location = new System.Drawing.Point(12, 39);
            this.TDESIV.Name = "TDESIV";
            this.TDESIV.Size = new System.Drawing.Size(494, 21);
            this.TDESIV.TabIndex = 4;
            this.TDESIV.Text = "201302270908";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 66);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.plaintext);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ciphertext);
            this.splitContainer1.Size = new System.Drawing.Size(494, 218);
            this.splitContainer1.SplitterDistance = 237;
            this.splitContainer1.TabIndex = 7;
            // 
            // ciphertext
            // 
            this.ciphertext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ciphertext.Location = new System.Drawing.Point(0, 0);
            this.ciphertext.Multiline = true;
            this.ciphertext.Name = "ciphertext";
            this.ciphertext.Size = new System.Drawing.Size(253, 218);
            this.ciphertext.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 321);
            this.Controls.Add(this.TDESIV);
            this.Controls.Add(this.TDESKey);
            this.Controls.Add(this.DecryptData);
            this.Controls.Add(this.EncryptData);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(504, 243);
            this.Name = "Main";
            this.Text = "TripleDES";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plaintext;
        private System.Windows.Forms.Button EncryptData;
        private System.Windows.Forms.Button DecryptData;
        private System.Windows.Forms.TextBox TDESKey;
        private System.Windows.Forms.TextBox TDESIV;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox ciphertext;
    }
}

