namespace RSA_LAB
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.tbP = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txBSrcToCrypt = new System.Windows.Forms.TextBox();
            this.txBCryptToDecrypt = new System.Windows.Forms.TextBox();
            this.lblOpenKey = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCloseKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "OPEN FILE....";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, -14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 129);
            this.label1.TabIndex = 1;
            this.label1.Text = "RSA";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(35, 124);
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(301, 22);
            this.tbQ.TabIndex = 2;
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(35, 214);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(301, 22);
            this.tbP.TabIndex = 3;
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(35, 307);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(301, 22);
            this.tbD.TabIndex = 4;
            // 
            // btnCrypt
            // 
            this.btnCrypt.BackColor = System.Drawing.Color.Black;
            this.btnCrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrypt.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrypt.Location = new System.Drawing.Point(34, 384);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(129, 56);
            this.btnCrypt.TabIndex = 5;
            this.btnCrypt.Text = "Crypt";
            this.btnCrypt.UseVisualStyleBackColor = false;
            this.btnCrypt.Visible = false;
            this.btnCrypt.Click += new System.EventHandler(this.BtnCrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ScriptS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Q:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ScriptS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 48);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter P :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ScriptS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 48);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter D :";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Black;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEncrypt.Location = new System.Drawing.Point(190, 384);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(129, 56);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Decrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Visible = false;
            this.btnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // txBSrcToCrypt
            // 
            this.txBSrcToCrypt.BackColor = System.Drawing.SystemColors.InfoText;
            this.txBSrcToCrypt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txBSrcToCrypt.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txBSrcToCrypt.ForeColor = System.Drawing.SystemColors.Window;
            this.txBSrcToCrypt.Location = new System.Drawing.Point(458, 140);
            this.txBSrcToCrypt.Multiline = true;
            this.txBSrcToCrypt.Name = "txBSrcToCrypt";
            this.txBSrcToCrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txBSrcToCrypt.Size = new System.Drawing.Size(187, 262);
            this.txBSrcToCrypt.TabIndex = 10;
            this.txBSrcToCrypt.Visible = false;
            // 
            // txBCryptToDecrypt
            // 
            this.txBCryptToDecrypt.BackColor = System.Drawing.SystemColors.InfoText;
            this.txBCryptToDecrypt.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txBCryptToDecrypt.ForeColor = System.Drawing.SystemColors.Window;
            this.txBCryptToDecrypt.Location = new System.Drawing.Point(701, 140);
            this.txBCryptToDecrypt.Multiline = true;
            this.txBCryptToDecrypt.Name = "txBCryptToDecrypt";
            this.txBCryptToDecrypt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txBCryptToDecrypt.Size = new System.Drawing.Size(189, 272);
            this.txBCryptToDecrypt.TabIndex = 11;
            this.txBCryptToDecrypt.Visible = false;
            // 
            // lblOpenKey
            // 
            this.lblOpenKey.AutoSize = true;
            this.lblOpenKey.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenKey.Location = new System.Drawing.Point(39, 481);
            this.lblOpenKey.Name = "lblOpenKey";
            this.lblOpenKey.Size = new System.Drawing.Size(221, 45);
            this.lblOpenKey.TabIndex = 12;
            this.lblOpenKey.Text = "Open Key (e,r) :";
            this.lblOpenKey.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(464, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sourse -> Crypt";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(712, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Crypt -> Decrypt";
            this.label8.Visible = false;
            // 
            // lblCloseKey
            // 
            this.lblCloseKey.AutoSize = true;
            this.lblCloseKey.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseKey.Location = new System.Drawing.Point(39, 551);
            this.lblCloseKey.Name = "lblCloseKey";
            this.lblCloseKey.Size = new System.Drawing.Size(228, 45);
            this.lblCloseKey.TabIndex = 16;
            this.lblCloseKey.Text = "Close Key (d,r) :";
            this.lblCloseKey.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(997, 641);
            this.Controls.Add(this.lblCloseKey);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblOpenKey);
            this.Controls.Add(this.txBCryptToDecrypt);
            this.Controls.Add(this.txBSrcToCrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCrypt);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.tbQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txBSrcToCrypt;
        private System.Windows.Forms.TextBox txBCryptToDecrypt;
        private System.Windows.Forms.Label lblOpenKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCloseKey;
    }
}

