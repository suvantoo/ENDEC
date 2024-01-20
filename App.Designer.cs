namespace encryption_app
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtSecretkey = new System.Windows.Forms.TextBox();
            this.txtIVkey = new System.Windows.Forms.TextBox();
            this.labelSecret = new System.Windows.Forms.Label();
            this.labelIV = new System.Windows.Forms.Label();
            this.btnGenSecret = new System.Windows.Forms.Button();
            this.btnGenIV = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLeft
            // 
            this.txtLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtLeft.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeft.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLeft.Location = new System.Drawing.Point(12, 200);
            this.txtLeft.Multiline = true;
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(359, 280);
            this.txtLeft.TabIndex = 0;
            // 
            // txtRight
            // 
            this.txtRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtRight.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRight.ForeColor = System.Drawing.SystemColors.Window;
            this.txtRight.Location = new System.Drawing.Point(525, 200);
            this.txtRight.Multiline = true;
            this.txtRight.Name = "txtRight";
            this.txtRight.ReadOnly = true;
            this.txtRight.Size = new System.Drawing.Size(359, 280);
            this.txtRight.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEncrypt.FlatAppearance.BorderSize = 2;
            this.btnEncrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Consolas", 9F);
            this.btnEncrypt.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEncrypt.Location = new System.Drawing.Point(402, 382);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(95, 30);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtSecretkey
            // 
            this.txtSecretkey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSecretkey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecretkey.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretkey.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSecretkey.Location = new System.Drawing.Point(214, 26);
            this.txtSecretkey.Multiline = true;
            this.txtSecretkey.Name = "txtSecretkey";
            this.txtSecretkey.Size = new System.Drawing.Size(192, 55);
            this.txtSecretkey.TabIndex = 4;
            // 
            // txtIVkey
            // 
            this.txtIVkey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIVkey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIVkey.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVkey.ForeColor = System.Drawing.SystemColors.Window;
            this.txtIVkey.Location = new System.Drawing.Point(575, 25);
            this.txtIVkey.Multiline = true;
            this.txtIVkey.Name = "txtIVkey";
            this.txtIVkey.Size = new System.Drawing.Size(192, 56);
            this.txtIVkey.TabIndex = 5;
            // 
            // labelSecret
            // 
            this.labelSecret.AutoSize = true;
            this.labelSecret.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecret.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSecret.Location = new System.Drawing.Point(211, 8);
            this.labelSecret.Name = "labelSecret";
            this.labelSecret.Size = new System.Drawing.Size(154, 15);
            this.labelSecret.TabIndex = 6;
            this.labelSecret.Text = "Secret Key [256 bits]";
            // 
            // labelIV
            // 
            this.labelIV.AutoSize = true;
            this.labelIV.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIV.Location = new System.Drawing.Point(572, 7);
            this.labelIV.Name = "labelIV";
            this.labelIV.Size = new System.Drawing.Size(98, 15);
            this.labelIV.TabIndex = 7;
            this.labelIV.Text = "IV [128 bits]";
            // 
            // btnGenSecret
            // 
            this.btnGenSecret.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnGenSecret.FlatAppearance.BorderSize = 2;
            this.btnGenSecret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenSecret.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenSecret.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGenSecret.Location = new System.Drawing.Point(214, 86);
            this.btnGenSecret.Name = "btnGenSecret";
            this.btnGenSecret.Size = new System.Drawing.Size(69, 23);
            this.btnGenSecret.TabIndex = 8;
            this.btnGenSecret.Text = "Generate";
            this.btnGenSecret.UseVisualStyleBackColor = true;
            this.btnGenSecret.Click += new System.EventHandler(this.btnGenSecret_Click);
            // 
            // btnGenIV
            // 
            this.btnGenIV.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.btnGenIV.FlatAppearance.BorderSize = 2;
            this.btnGenIV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenIV.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenIV.ForeColor = System.Drawing.SystemColors.Info;
            this.btnGenIV.Location = new System.Drawing.Point(575, 86);
            this.btnGenIV.Name = "btnGenIV";
            this.btnGenIV.Size = new System.Drawing.Size(69, 23);
            this.btnGenIV.TabIndex = 9;
            this.btnGenIV.Text = "Generate";
            this.btnGenIV.UseVisualStyleBackColor = false;
            this.btnGenIV.Click += new System.EventHandler(this.btnGenIV_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnDecrypt.FlatAppearance.BorderSize = 2;
            this.btnDecrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDecrypt.Location = new System.Drawing.Point(402, 447);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(95, 29);
            this.btnDecrypt.TabIndex = 10;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel1.Controls.Add(this.labelIV);
            this.panel1.Controls.Add(this.btnGenSecret);
            this.panel1.Controls.Add(this.btnGenIV);
            this.panel1.Controls.Add(this.txtSecretkey);
            this.panel1.Controls.Add(this.labelSecret);
            this.panel1.Controls.Add(this.txtIVkey);
            this.panel1.Location = new System.Drawing.Point(-35, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 121);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F);
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "INPUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F);
            this.label2.Location = new System.Drawing.Point(522, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 13;
            this.label2.Text = "OUTPUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F);
            this.label3.Location = new System.Drawing.Point(9, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "The Advanced Encryption Standard [AES]";
            // 
            // App
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(896, 553);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENDEC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtSecretkey;
        private System.Windows.Forms.TextBox txtIVkey;
        private System.Windows.Forms.Label labelSecret;
        private System.Windows.Forms.Label labelIV;
        private System.Windows.Forms.Button btnGenSecret;
        private System.Windows.Forms.Button btnGenIV;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

