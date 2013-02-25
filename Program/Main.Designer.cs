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
            this.textbox = new System.Windows.Forms.TextBox();
            this.EncryptData = new System.Windows.Forms.Button();
            this.DecryptData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox
            // 
            this.textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox.Location = new System.Drawing.Point(12, 12);
            this.textbox.Multiline = true;
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(464, 156);
            this.textbox.TabIndex = 0;
            // 
            // EncryptData
            // 
            this.EncryptData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EncryptData.Location = new System.Drawing.Point(12, 174);
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
            this.DecryptData.Location = new System.Drawing.Point(93, 174);
            this.DecryptData.Name = "DecryptData";
            this.DecryptData.Size = new System.Drawing.Size(75, 23);
            this.DecryptData.TabIndex = 2;
            this.DecryptData.Text = "Decrypt";
            this.DecryptData.UseVisualStyleBackColor = true;
            this.DecryptData.Click += new System.EventHandler(this.DecryptData_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 205);
            this.Controls.Add(this.DecryptData);
            this.Controls.Add(this.EncryptData);
            this.Controls.Add(this.textbox);
            this.MinimumSize = new System.Drawing.Size(504, 243);
            this.Name = "Main";
            this.Text = "TripleDES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button EncryptData;
        private System.Windows.Forms.Button DecryptData;
    }
}

