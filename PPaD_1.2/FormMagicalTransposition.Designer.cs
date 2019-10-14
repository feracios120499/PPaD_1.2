namespace PPaD_1._2
{
    partial class FormMagicalTransposition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBoxDecrypt = new System.Windows.Forms.TextBox();
            this.textBoxDecryptOriginal = new System.Windows.Forms.TextBox();
            this.textBoxEncrypt = new System.Windows.Forms.TextBox();
            this.textBoxEncryptOriginal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(125, 421);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(585, 39);
            this.buttonDecrypt.TabIndex = 88;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.ButtonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(125, 207);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(585, 39);
            this.buttonEncrypt.TabIndex = 89;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.ButtonEncrypt_Click);
            // 
            // textBoxDecrypt
            // 
            this.textBoxDecrypt.Location = new System.Drawing.Point(125, 355);
            this.textBoxDecrypt.Multiline = true;
            this.textBoxDecrypt.Name = "textBoxDecrypt";
            this.textBoxDecrypt.ReadOnly = true;
            this.textBoxDecrypt.Size = new System.Drawing.Size(585, 48);
            this.textBoxDecrypt.TabIndex = 84;
            // 
            // textBoxDecryptOriginal
            // 
            this.textBoxDecryptOriginal.Location = new System.Drawing.Point(125, 291);
            this.textBoxDecryptOriginal.Multiline = true;
            this.textBoxDecryptOriginal.Name = "textBoxDecryptOriginal";
            this.textBoxDecryptOriginal.Size = new System.Drawing.Size(585, 48);
            this.textBoxDecryptOriginal.TabIndex = 85;
            // 
            // textBoxEncrypt
            // 
            this.textBoxEncrypt.Location = new System.Drawing.Point(125, 141);
            this.textBoxEncrypt.Multiline = true;
            this.textBoxEncrypt.Name = "textBoxEncrypt";
            this.textBoxEncrypt.ReadOnly = true;
            this.textBoxEncrypt.Size = new System.Drawing.Size(585, 48);
            this.textBoxEncrypt.TabIndex = 86;
            // 
            // textBoxEncryptOriginal
            // 
            this.textBoxEncryptOriginal.Location = new System.Drawing.Point(125, 77);
            this.textBoxEncryptOriginal.Multiline = true;
            this.textBoxEncryptOriginal.Name = "textBoxEncryptOriginal";
            this.textBoxEncryptOriginal.Size = new System.Drawing.Size(585, 48);
            this.textBoxEncryptOriginal.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 83;
            this.label2.Text = "Decrypt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 82;
            this.label1.Text = "Encrypt";
            // 
            // FormMagicalTransposition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 488);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxDecrypt);
            this.Controls.Add(this.textBoxDecryptOriginal);
            this.Controls.Add(this.textBoxEncrypt);
            this.Controls.Add(this.textBoxEncryptOriginal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMagicalTransposition";
            this.Text = "FormMagicalTransposition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxDecrypt;
        private System.Windows.Forms.TextBox textBoxDecryptOriginal;
        private System.Windows.Forms.TextBox textBoxEncrypt;
        private System.Windows.Forms.TextBox textBoxEncryptOriginal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}