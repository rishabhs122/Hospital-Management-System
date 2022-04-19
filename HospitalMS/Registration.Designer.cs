namespace HospitalMS
{
    partial class Registration
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regUsername = new System.Windows.Forms.TextBox();
            this.regPass2 = new System.Windows.Forms.TextBox();
            this.regPass1 = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnGotologin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Indigo;
            this.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUsername.Location = new System.Drawing.Point(104, 83);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(171, 42);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Enter Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Indigo;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(104, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Indigo;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(104, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // regUsername
            // 
            this.regUsername.Location = new System.Drawing.Point(367, 87);
            this.regUsername.Name = "regUsername";
            this.regUsername.Size = new System.Drawing.Size(355, 27);
            this.regUsername.TabIndex = 3;
            // 
            // regPass2
            // 
            this.regPass2.Location = new System.Drawing.Point(367, 284);
            this.regPass2.Name = "regPass2";
            this.regPass2.Size = new System.Drawing.Size(355, 27);
            this.regPass2.TabIndex = 4;
            // 
            // regPass1
            // 
            this.regPass1.Location = new System.Drawing.Point(367, 188);
            this.regPass1.Name = "regPass1";
            this.regPass1.Size = new System.Drawing.Size(355, 27);
            this.regPass1.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Green;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(486, 380);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(130, 45);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnGotologin
            // 
            this.btnGotologin.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGotologin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGotologin.ForeColor = System.Drawing.Color.White;
            this.btnGotologin.Location = new System.Drawing.Point(461, 447);
            this.btnGotologin.Name = "btnGotologin";
            this.btnGotologin.Size = new System.Drawing.Size(174, 45);
            this.btnGotologin.TabIndex = 7;
            this.btnGotologin.Text = "Go to Login Page";
            this.btnGotologin.UseVisualStyleBackColor = false;
            this.btnGotologin.Click += new System.EventHandler(this.btnGotologin_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HospitalMS.Properties.Resources._4113098;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1442, 683);
            this.Controls.Add(this.btnGotologin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.regPass1);
            this.Controls.Add(this.regPass2);
            this.Controls.Add(this.regUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsername);
            this.DoubleBuffered = true;
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUsername;
        private Label label2;
        private Label label3;
        private TextBox regUsername;
        private TextBox regPass2;
        private TextBox regPass1;
        private Button btnRegister;
        private Button btnGotologin;
    }
}