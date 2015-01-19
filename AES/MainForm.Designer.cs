namespace AES
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncryptC = new System.Windows.Forms.Button();
            this.btnDecryptASM = new System.Windows.Forms.Button();
            this.btnDecryptC = new System.Windows.Forms.Button();
            this.richTextBoxEncrypt = new System.Windows.Forms.RichTextBox();
            this.btnEncryptASM = new System.Windows.Forms.Button();
            this.richTextBoxDecrypt = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(35, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tekst do zaszyfrowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(35, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wynikowy zaszyfrowany ciąg:";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Szyfrowanie AES";
            // 
            // btnEncryptC
            // 
            this.btnEncryptC.BackColor = System.Drawing.Color.LightCoral;
            this.btnEncryptC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncryptC.Location = new System.Drawing.Point(580, 109);
            this.btnEncryptC.Name = "btnEncryptC";
            this.btnEncryptC.Size = new System.Drawing.Size(121, 31);
            this.btnEncryptC.TabIndex = 5;
            this.btnEncryptC.Text = "SZYFRUJ C";
            this.btnEncryptC.UseVisualStyleBackColor = false;
            this.btnEncryptC.Click += new System.EventHandler(this.btnEncryptC_Click);
            // 
            // btnDecryptASM
            // 
            this.btnDecryptASM.BackColor = System.Drawing.Color.LightCoral;
            this.btnDecryptASM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecryptASM.Location = new System.Drawing.Point(580, 413);
            this.btnDecryptASM.Name = "btnDecryptASM";
            this.btnDecryptASM.Size = new System.Drawing.Size(121, 31);
            this.btnDecryptASM.TabIndex = 6;
            this.btnDecryptASM.Text = "DESZYFRUJ ASM";
            this.btnDecryptASM.UseVisualStyleBackColor = false;
            this.btnDecryptASM.Click += new System.EventHandler(this.btnDecryptASM_Click);
            // 
            // btnDecryptC
            // 
            this.btnDecryptC.BackColor = System.Drawing.Color.LightCoral;
            this.btnDecryptC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecryptC.Location = new System.Drawing.Point(580, 352);
            this.btnDecryptC.Name = "btnDecryptC";
            this.btnDecryptC.Size = new System.Drawing.Size(121, 31);
            this.btnDecryptC.TabIndex = 7;
            this.btnDecryptC.Text = "DESZYFRUJ C";
            this.btnDecryptC.UseVisualStyleBackColor = false;
            this.btnDecryptC.Click += new System.EventHandler(this.btnDecryptC_Click);
            // 
            // richTextBoxEncrypt
            // 
            this.richTextBoxEncrypt.Location = new System.Drawing.Point(38, 93);
            this.richTextBoxEncrypt.Name = "richTextBoxEncrypt";
            this.richTextBoxEncrypt.Size = new System.Drawing.Size(510, 155);
            this.richTextBoxEncrypt.TabIndex = 8;
            this.richTextBoxEncrypt.Text = "";
            // 
            // btnEncryptASM
            // 
            this.btnEncryptASM.BackColor = System.Drawing.Color.LightCoral;
            this.btnEncryptASM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncryptASM.Location = new System.Drawing.Point(580, 167);
            this.btnEncryptASM.Name = "btnEncryptASM";
            this.btnEncryptASM.Size = new System.Drawing.Size(121, 31);
            this.btnEncryptASM.TabIndex = 9;
            this.btnEncryptASM.Text = "SZYFRUJ ASM";
            this.btnEncryptASM.UseVisualStyleBackColor = false;
            this.btnEncryptASM.Click += new System.EventHandler(this.btnEncryptASM_Click);
            // 
            // richTextBoxDecrypt
            // 
            this.richTextBoxDecrypt.Location = new System.Drawing.Point(38, 335);
            this.richTextBoxDecrypt.Name = "richTextBoxDecrypt";
            this.richTextBoxDecrypt.Size = new System.Drawing.Size(510, 149);
            this.richTextBoxDecrypt.TabIndex = 10;
            this.richTextBoxDecrypt.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(35, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Klucz (max 32 znaki):";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(170, 274);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(378, 20);
            this.textBoxKey.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 508);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxDecrypt);
            this.Controls.Add(this.btnEncryptASM);
            this.Controls.Add(this.richTextBoxEncrypt);
            this.Controls.Add(this.btnDecryptC);
            this.Controls.Add(this.btnDecryptASM);
            this.Controls.Add(this.btnEncryptC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Szyfrowanie AES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncryptC;
        private System.Windows.Forms.Button btnDecryptASM;
        private System.Windows.Forms.Button btnDecryptC;
        private System.Windows.Forms.RichTextBox richTextBoxEncrypt;
        private System.Windows.Forms.Button btnEncryptASM;
        private System.Windows.Forms.RichTextBox richTextBoxDecrypt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKey;
    }
}

