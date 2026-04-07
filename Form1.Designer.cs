namespace RSA_Algorithms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.TextBox txtCiphertext;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtExplanation;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblCiphertext;
        private System.Windows.Forms.Label lblDecrypted;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblStoredPublicKey;
        private System.Windows.Forms.TextBox txtStoredPublicKey;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblP = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.txtCiphertext = new System.Windows.Forms.TextBox();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtExplanation = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblCiphertext = new System.Windows.Forms.Label();
            this.lblDecrypted = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblStoredPublicKey = new System.Windows.Forms.Label();
            this.txtStoredPublicKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(20, 20);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(61, 16);
            this.lblP.TabIndex = 0;
            this.lblP.Text = "Prime p:";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(20, 55);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(62, 16);
            this.lblQ.TabIndex = 1;
            this.lblQ.Text = "Prime q:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(20, 90);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(85, 16);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "Initial text x:";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(120, 17);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(180, 22);
            this.txtP.TabIndex = 3;
            this.txtP.Text = "17";
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(120, 52);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(180, 22);
            this.txtQ.TabIndex = 4;
            this.txtQ.Text = "23";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(120, 87);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(390, 22);
            this.txtInput.TabIndex = 5;
            this.txtInput.Text = "Hello RSA";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(530, 15);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(210, 30);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "1. Calculate RSA Parameters";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(530, 51);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(210, 30);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "2. Encrypt Text";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(530, 87);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "3. Save Ciphertext + Public Key";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(760, 15);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(185, 30);
            this.btnRead.TabIndex = 9;
            this.btnRead.Text = "4. Read Ciphertext";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(760, 51);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(185, 66);
            this.btnDecrypt.TabIndex = 10;
            this.btnDecrypt.Text = "5. Decrypt by Factoring n and Restoring Text";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(23, 159);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(457, 218);
            this.txtResults.TabIndex = 11;
            // 
            // txtCiphertext
            // 
            this.txtCiphertext.Location = new System.Drawing.Point(500, 159);
            this.txtCiphertext.Multiline = true;
            this.txtCiphertext.Name = "txtCiphertext";
            this.txtCiphertext.ReadOnly = true;
            this.txtCiphertext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCiphertext.Size = new System.Drawing.Size(445, 85);
            this.txtCiphertext.TabIndex = 12;
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(500, 282);
            this.txtDecrypted.Multiline = true;
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.ReadOnly = true;
            this.txtDecrypted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDecrypted.Size = new System.Drawing.Size(445, 95);
            this.txtDecrypted.TabIndex = 13;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(23, 412);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(922, 42);
            this.txtStatus.TabIndex = 14;
            // 
            // txtExplanation
            // 
            this.txtExplanation.Location = new System.Drawing.Point(23, 489);
            this.txtExplanation.Multiline = true;
            this.txtExplanation.Name = "txtExplanation";
            this.txtExplanation.ReadOnly = true;
            this.txtExplanation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExplanation.Size = new System.Drawing.Size(922, 130);
            this.txtExplanation.TabIndex = 15;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(20, 140);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(156, 16);
            this.lblResults.TabIndex = 16;
            this.lblResults.Text = "Calculated Parameters:";
            // 
            // lblCiphertext
            // 
            this.lblCiphertext.AutoSize = true;
            this.lblCiphertext.Location = new System.Drawing.Point(497, 140);
            this.lblCiphertext.Name = "lblCiphertext";
            this.lblCiphertext.Size = new System.Drawing.Size(136, 16);
            this.lblCiphertext.TabIndex = 17;
            this.lblCiphertext.Text = "Encrypted Text Data:";
            // 
            // lblDecrypted
            // 
            this.lblDecrypted.AutoSize = true;
            this.lblDecrypted.Location = new System.Drawing.Point(497, 263);
            this.lblDecrypted.Name = "lblDecrypted";
            this.lblDecrypted.Size = new System.Drawing.Size(106, 16);
            this.lblDecrypted.TabIndex = 18;
            this.lblDecrypted.Text = "Decrypted Text:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 393);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 16);
            this.lblStatus.TabIndex = 19;
            this.lblStatus.Text = "Status:";
            // 
            // lblExplanation
            // 
            this.lblExplanation.AutoSize = true;
            this.lblExplanation.Location = new System.Drawing.Point(20, 470);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(173, 16);
            this.lblExplanation.TabIndex = 20;
            this.lblExplanation.Text = "RSA Algorithm Explanation:";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(20, 123);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(58, 16);
            this.lblFilePath.TabIndex = 21;
            this.lblFilePath.Text = "File path:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(120, 120);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(390, 22);
            this.txtFilePath.TabIndex = 22;
            // 
            // lblStoredPublicKey
            // 
            this.lblStoredPublicKey.AutoSize = true;
            this.lblStoredPublicKey.Location = new System.Drawing.Point(497, 247);
            this.lblStoredPublicKey.Name = "lblStoredPublicKey";
            this.lblStoredPublicKey.Size = new System.Drawing.Size(116, 16);
            this.lblStoredPublicKey.TabIndex = 23;
            this.lblStoredPublicKey.Text = "Stored Public Key:";
            // 
            // txtStoredPublicKey
            // 
            this.txtStoredPublicKey.Location = new System.Drawing.Point(619, 244);
            this.txtStoredPublicKey.Name = "txtStoredPublicKey";
            this.txtStoredPublicKey.ReadOnly = true;
            this.txtStoredPublicKey.Size = new System.Drawing.Size(326, 22);
            this.txtStoredPublicKey.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 639);
            this.Controls.Add(this.txtStoredPublicKey);
            this.Controls.Add(this.lblStoredPublicKey);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDecrypted);
            this.Controls.Add(this.lblCiphertext);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.txtExplanation);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.txtCiphertext);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA Algorithms Assignment";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
