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
            this.tbH = new System.Windows.Forms.TextBox();
            this.btnCrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblHash = new System.Windows.Forms.Label();
            this.lblEDS = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbK = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblWait = new System.Windows.Forms.Label();
            this.lblReceive = new System.Windows.Forms.Label();
            this.lblHash2 = new System.Windows.Forms.Label();
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
            this.button1.Size = new System.Drawing.Size(205, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "OPEN SOURSE FILE....";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, -8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 129);
            this.label1.TabIndex = 1;
            this.label1.Text = "EDS (DSA)";
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
            this.tbQ.Text = "433";
            // 
            // tbP
            // 
            this.tbP.Location = new System.Drawing.Point(35, 214);
            this.tbP.Name = "tbP";
            this.tbP.Size = new System.Drawing.Size(301, 22);
            this.tbP.TabIndex = 3;
            this.tbP.Text = "19919";
            // 
            // tbH
            // 
            this.tbH.Location = new System.Drawing.Point(35, 307);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(301, 22);
            this.tbH.TabIndex = 4;
            this.tbH.Text = "2";
            // 
            // btnCrypt
            // 
            this.btnCrypt.BackColor = System.Drawing.Color.Black;
            this.btnCrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrypt.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrypt.Location = new System.Drawing.Point(35, 557);
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.Size = new System.Drawing.Size(188, 56);
            this.btnCrypt.TabIndex = 5;
            this.btnCrypt.Text = "Underwrite";
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
            this.label4.Size = new System.Drawing.Size(166, 48);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter H:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Black;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEncrypt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEncrypt.Location = new System.Drawing.Point(367, 239);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(129, 56);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Validate";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Visible = false;
            this.btnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHash.Location = new System.Drawing.Point(359, 121);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(201, 45);
            this.lblHash.TabIndex = 12;
            this.lblHash.Text = "Message hash :";
            this.lblHash.Visible = false;
            // 
            // lblEDS
            // 
            this.lblEDS.AutoSize = true;
            this.lblEDS.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEDS.Location = new System.Drawing.Point(359, 191);
            this.lblEDS.Name = "lblEDS";
            this.lblEDS.Size = new System.Drawing.Size(175, 45);
            this.lblEDS.TabIndex = 16;
            this.lblEDS.Text = "EDS (R,S) :";
            this.lblEDS.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("ScriptS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 48);
            this.label5.TabIndex = 18;
            this.label5.Text = "Enter X:";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(35, 404);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(301, 22);
            this.tbX.TabIndex = 17;
            this.tbX.Text = "11";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("ScriptS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 48);
            this.label6.TabIndex = 20;
            this.label6.Text = "Enter K:";
            // 
            // tbK
            // 
            this.tbK.Location = new System.Drawing.Point(35, 505);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(301, 22);
            this.tbK.TabIndex = 19;
            this.tbK.Text = "17";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe Script", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(728, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(267, 59);
            this.button2.TabIndex = 21;
            this.button2.Text = "OPEN FILE FOR VALIDATION....";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWait.Location = new System.Drawing.Point(354, 393);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(229, 45);
            this.lblWait.TabIndex = 22;
            this.lblWait.Text = "Waiting for (R)";
            this.lblWait.Visible = false;
            // 
            // lblReceive
            // 
            this.lblReceive.AutoSize = true;
            this.lblReceive.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceive.Location = new System.Drawing.Point(361, 454);
            this.lblReceive.Name = "lblReceive";
            this.lblReceive.Size = new System.Drawing.Size(184, 45);
            this.lblReceive.TabIndex = 23;
            this.lblReceive.Text = "Received (V)";
            this.lblReceive.Visible = false;
            this.lblReceive.Click += new System.EventHandler(this.LblReceive_Click);
            // 
            // lblHash2
            // 
            this.lblHash2.AutoSize = true;
            this.lblHash2.Font = new System.Drawing.Font("Viner Hand ITC", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHash2.Location = new System.Drawing.Point(359, 324);
            this.lblHash2.Name = "lblHash2";
            this.lblHash2.Size = new System.Drawing.Size(201, 45);
            this.lblHash2.TabIndex = 24;
            this.lblHash2.Text = "Message hash :";
            this.lblHash2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(997, 641);
            this.Controls.Add(this.lblHash2);
            this.Controls.Add(this.lblReceive);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblEDS);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCrypt);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.tbP);
            this.Controls.Add(this.tbQ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "EDS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.TextBox tbP;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.Button btnCrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.Label lblEDS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbK;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.Label lblReceive;
        private System.Windows.Forms.Label lblHash2;
    }
}

